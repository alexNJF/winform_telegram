
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
        Controlls ctrl = new Controlls();

        public TelegramBotPanel()
        {
            InitializeComponent();
            Controlls.SSL();
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
                BotStart_Botton.BackColor = Color.Orange;
                BotStart_Botton.Text = "عدم اتصال";
                BotStatus_ListBox.Items.Insert(0,ex.Message);
                

            }
        }
        private void Bot_Log(T_result NewUpdates)
        {
            string Log_String;
            foreach (var item in NewUpdates.result)
            {
                message message = item.message;
                Log_String = "شماره پیام : " + item.update_id.ToString() + "\t" +
                             "نام درخواست دهنده:" + message.from.first_name.ToString() + "\t" +
                             "یوزر درخواست دهنده :" + message.from.username.ToString() + "\t" +
                             "متن درخواست :" + message.text.ToString();
                BotStatus_ListBox.Items.Insert(0,Log_String);
            }
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

        private void BotStart_Botton_Click(object sender, EventArgs e)
        {
            UpdateChecker_Timer.Start();
            BotStart_Botton.BackColor = Color.Olive;
            BotStart_Botton.Text = "در حال اتصال ... ";
            BotStart_Botton.Enabled = false;
        }

        private void BotStop_Botton_Click(object sender, EventArgs e)
        {
            UpdateChecker_Timer.Stop();
            BotStart_Botton.BackColor = Color.Orange;
            BotStart_Botton.Text = "اتصال ";
            BotStart_Botton.Enabled = true;
        }
    }
}
