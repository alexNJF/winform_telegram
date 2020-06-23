
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot
{
    public partial class TelegramBotPanel : Form
    {
        #region Form Flaging State
        bool windows_state_flag = true;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }


        #endregion
        #region Bot Conifg
        Controlls ctrl = new Controlls();
        int RestartBot_Counter = 60;

        public TelegramBotPanel()
        {
            InitializeComponent();
            Controlls.SSL();
            BotStatus_ListBox.DrawMode = DrawMode.OwnerDrawFixed;
            BotStatus_ListBox.DrawItem += new DrawItemEventHandler(BotStatus_listBox_SetColor);
        }

        void BotStatus_listBox_SetColor(object sender, DrawItemEventArgs e)
        {
            /*
             * Change listBox mode and Check if text is contain Error Color Change 
             */
            try
            {
                e.DrawBackground();
                Brush myBrush = Brushes.White;

                string[] log = ((ListBox)sender).Items[e.Index].ToString().Split(' ');



                if (log[0] == "ERROR:")
                {
                    myBrush = Brushes.Red;

                }
                else
                {
                    myBrush = Brushes.Black;
                }

                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

                e.DrawFocusRectangle();
            }
            catch
            {

            }

        }
        #endregion

        private void BotStart_Botton_Click(object sender, EventArgs e)
        {
            try
            {

                    BackgroundWorker_GetUpdate.RunWorkerAsync();
                    BotStart_Botton.BackColor = Color.Olive;
                    BotStart_Botton.Text = " ... در حال اتصال";
                    BotStart_Botton.Enabled = false;
            }
            catch(Exception ex)
            {
                warning_log(ex.Message);
            }

        }

        private void UpdateChecker_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string last_index = ctrl.read_index();
                T_result new_massage = ctrl.get_update(last_index);
                BotStart_Botton.BackColor = Color.Green;
                BotStart_Botton.Text = "متصل شد ";
                if (new_massage.result.Count > 0)
                {
                    Bot_Log(new_massage);
                    ctrl.responce(new_massage);
                    ctrl.save_index(ctrl.get_update());
                }
            }
            catch (Exception ex)
            {
                BotStart_Botton.BackColor = Color.Orange;
                BotStart_Botton.Enabled = true;
                BotStart_Botton.Text = "عدم اتصال";
                warning_log(ex.Message);
            }
        }

        private void Bot_Log(T_result NewUpdates)
        {
            foreach (var item in NewUpdates.result)
            {
                Data_log(item);
            }
        }

        #region BotStatus Log 
        private void warning_log(string Error)
        {
            string Log_string = "ERROR: " + "\t" +
                                DateTime.Now.ToShortDateString() + "   " +
                                DateTime.Now.ToLongTimeString() + "   " +
                                Error;
            BotStatus_ListBox.Invoke((Action)(()=> BotStatus_ListBox.Items.Insert(0, Log_string)));
            
        
        }

        private void Data_log(Update item)
        {
            message message = item.message;
            string Log_String = DateTime.Now.ToShortDateString() + "   " +
                                DateTime.Now.ToLongTimeString() + "   " +
                                " USER: " + message.from.first_name?.ToString() + " " + message.from.last_name?.ToString() + "( @" + message.from.username?.ToString() + " )" + "   " +
                                message.text.ToString();
            BotStatus_ListBox.Invoke((Action)(() => BotStatus_ListBox.Items.Insert(0, Log_String)));
        }

        #endregion

        private void BotStop_Botton_Click(object sender, EventArgs e)
        {
            BackgroundWorker_GetUpdate.CancelAsync();  
        }

        private void TelegramBotPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            string LogFilePath = "BotLog.txt";
            using (TextWriter tw = new StreamWriter(LogFilePath, true))
            {
                foreach (String s in BotStatus_ListBox.Items)
                    tw.WriteLine(s);
            }
            MessageBox.Show("اطلاعات در مسیر زیر ذخیره شدند  \n " + LogFilePath);
        }

        private void BackgroundWorker_GetUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (BackgroundWorker_GetUpdate.CancellationPending)
                {
                    e.Cancel = true;
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.BackColor = Color.Orange));
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.Text = "اتصال "));
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.Enabled = true));
                    break;
                }

                try
                {
                    string last_index = ctrl.read_index();
                    T_result new_massage = ctrl.get_update(last_index);
                    BotStart_Botton.Invoke((Action)(()=> BotStart_Botton.BackColor = Color.Green));
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.Text = "متصل شد "));
                    if (new_massage.result.Count > 0)
                    {
                        Bot_Log(new_massage);
                        ctrl.responce(new_massage);
                        ctrl.save_index(ctrl.get_update());
                    }
                }
                catch (Exception ex)
                {
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.Enabled = true));
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.BackColor = Color.Tomato));
                    BotStart_Botton.Invoke((Action)(() => BotStart_Botton.Text = "... عدم اتصال ، تلاش برای اتصال مجدد"));
                    warning_log(ex.Message);   
                }
            }
        }

        private void ProductMenuItem_Click(object sender, EventArgs e)
        {
            new Product_Form().Show();

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Button_Click(object sender, EventArgs e)
        {
            if(windows_state_flag)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            windows_state_flag = !windows_state_flag;

        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;
        }

        private void TelegramBotPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
