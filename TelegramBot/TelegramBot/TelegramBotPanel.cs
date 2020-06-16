
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

        private void ProxyAuth_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProxyAuth_CheckBox.Checked)
            {
                ProxyAuthUserName_TextBox.Enabled = true;
                ProxyAuthPassword_TextBox.Enabled=true;
            }
            else
            {
                ProxyAuthUserName_TextBox.Enabled = false;
                ProxyAuthPassword_TextBox.Enabled = false;
            }
        }
        private void BotStartStop_Botton_Click(object sender, EventArgs e)
        {
            UpdateChecker_Timer.Start();
            BotStartStop_Botton.BackColor = Color.Olive;
            BotStartStop_Botton.Text = "در حال اتصال ... ";
        }

        private void UpdateChecker_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string last_index = ctrl.read_index();
                T_result new_massage = ctrl.get_update(last_index);
                BotStartStop_Botton.BackColor = Color.Green;
                BotStartStop_Botton.Text = "متصل شد ";

                if (new_massage.result.Count > 0)
                {
                    Bot_Log(new_massage);
                    ctrl.responce(new_massage);
                    ctrl.save_index(ctrl.get_update());
                }
            }
            catch(Exception ex)
            {
                UpdateChecker_Timer.Stop();
                BotStartStop_Botton.BackColor = Color.Orange;
                BotStartStop_Botton.Text = "عدم اتصال";
                BotStatus_ListBox.Items.Add( ex.Message);
            }
        }
        private void Bot_Log(T_result NewUpdates)
        {
            string Log_String;
            foreach (var item in NewUpdates.result)
            {
                message message = item.message;
                Log_String = "شماره پیام : " + item.update_id.ToString() +
                             "نام درخواست دهنده:" + message.from.first_name.ToString() +
                             "یوزر درخواست دهنده :" + message.from.username.ToString() +
                             "متن درخواست :" + message.text.ToString();
                BotStatus_ListBox.Items.Add(Log_String);
            }
        }

        private void TelegramBotPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            string LogFilePath = "BotLog.txt";
            using (TextWriter tw = new StreamWriter(LogFilePath,true))
            {
                foreach (String s in BotStatus_ListBox.Items)
                    tw.WriteLine(s);
            }
            MessageBox.Show("اطلاعات در مسیر زیر ذخیره شدند  \n " + LogFilePath);
        }
    }
}
