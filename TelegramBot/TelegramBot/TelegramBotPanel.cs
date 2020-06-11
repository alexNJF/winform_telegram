using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot
{
    public partial class TelegramBotPanel : Form
    {
        public TelegramBotPanel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProxyAuth_GpBox_Enter(object sender, EventArgs e)
        {

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

        private void ProxySet_Bottun_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
