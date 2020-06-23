
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
            UpdateChecker_Timer.Start();
            ResetTimer();
            BotStart_Botton.BackColor = Color.Olive;
            BotStart_Botton.Text = " ... در حال اتصال";
            BotStart_Botton.Enabled = false;
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
                UpdateChecker_Timer.Stop();
                ReStartBot_timer.Start();
                BotStart_Botton.BackColor = Color.Orange;
                BotStart_Botton.Enabled = true;
                BotStart_Botton.Text = "عدم اتصال";
                warning_log(ex.Message);
            }
        }

        private void ReStartBot_timer_Tick(object sender, EventArgs e)
        {
            BotStart_Botton.Text = " اتصال پس از " + RestartBot_Counter + "ثانیه ";
            RestartBot_Counter--;
            if (RestartBot_Counter == 0)
            {
                ResetTimer();
                BotStart_Botton_Click(null, null);
            }

        }

        private void ResetTimer()
        {
            RestartBot_Counter = 60;
            ReStartBot_timer.Stop();
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
            BotStatus_ListBox.Items.Insert(0, Log_string);
        }

        private void Data_log(Update item)
        {
            message message = item.message;
            string Log_String = DateTime.Now.ToShortDateString() + "   " +
                                DateTime.Now.ToLongTimeString() + "   " +
                                " USER: " + message.from.first_name?.ToString() + " " + message.from.last_name?.ToString() + "( @" + message.from.username?.ToString() + " )" + "   " +
                                message.text.ToString();
            BotStatus_ListBox.Items.Insert(0, Log_String);
        }

        #endregion

        private void BotStop_Botton_Click(object sender, EventArgs e)
        {
            UpdateChecker_Timer.Stop();
            ReStartBot_timer.Stop();
            BotStart_Botton.BackColor = Color.Orange;
            BotStart_Botton.Text = "اتصال ";
            BotStart_Botton.Enabled = true;
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

    }
}
