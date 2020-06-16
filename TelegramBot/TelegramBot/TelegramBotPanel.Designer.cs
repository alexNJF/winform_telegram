namespace TelegramBot
{
    partial class TelegramBotPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BotTabControl = new System.Windows.Forms.TabControl();
            this.BotMainPanel_Tab = new System.Windows.Forms.TabPage();
            this.BotStartStop_Botton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BotStatus_ListBox = new System.Windows.Forms.ListBox();
            this.BotSetting_Tab = new System.Windows.Forms.TabPage();
            this.Proxy_GroupBox = new System.Windows.Forms.GroupBox();
            this.ProxyTest_Bottun = new System.Windows.Forms.Button();
            this.ProxySet_Bottun = new System.Windows.Forms.Button();
            this.ProxyAuth_GpBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProxyAuthPassword_TextBox = new System.Windows.Forms.TextBox();
            this.ProxyAuthUserName_TextBox = new System.Windows.Forms.TextBox();
            this.ProxyAuth_CheckBox = new System.Windows.Forms.CheckBox();
            this.ProxyProtocol_GpBox = new System.Windows.Forms.GroupBox();
            this.ProxyProtocolSocks5_RadioButton = new System.Windows.Forms.RadioButton();
            this.ProxyProtocolSocks4_RadioButton = new System.Windows.Forms.RadioButton();
            this.ProxyProtocolHttps_RadioButton = new System.Windows.Forms.RadioButton();
            this.ProxyServer_GpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProxyServerProt_TextBox = new System.Windows.Forms.TextBox();
            this.ProxyServerAddress_TextBox = new System.Windows.Forms.TextBox();
            this.UpdateChecker_Timer = new System.Windows.Forms.Timer(this.components);
            this.BotTabControl.SuspendLayout();
            this.BotMainPanel_Tab.SuspendLayout();
            this.BotSetting_Tab.SuspendLayout();
            this.Proxy_GroupBox.SuspendLayout();
            this.ProxyAuth_GpBox.SuspendLayout();
            this.ProxyProtocol_GpBox.SuspendLayout();
            this.ProxyServer_GpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotTabControl
            // 
            this.BotTabControl.Controls.Add(this.BotMainPanel_Tab);
            this.BotTabControl.Controls.Add(this.BotSetting_Tab);
            this.BotTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotTabControl.Location = new System.Drawing.Point(0, 0);
            this.BotTabControl.Name = "BotTabControl";
            this.BotTabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotTabControl.RightToLeftLayout = true;
            this.BotTabControl.SelectedIndex = 0;
            this.BotTabControl.Size = new System.Drawing.Size(616, 359);
            this.BotTabControl.TabIndex = 0;
            // 
            // BotMainPanel_Tab
            // 
            this.BotMainPanel_Tab.Controls.Add(this.BotStartStop_Botton);
            this.BotMainPanel_Tab.Controls.Add(this.label5);
            this.BotMainPanel_Tab.Controls.Add(this.BotStatus_ListBox);
            this.BotMainPanel_Tab.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.BotMainPanel_Tab.Location = new System.Drawing.Point(4, 22);
            this.BotMainPanel_Tab.Name = "BotMainPanel_Tab";
            this.BotMainPanel_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.BotMainPanel_Tab.Size = new System.Drawing.Size(608, 333);
            this.BotMainPanel_Tab.TabIndex = 0;
            this.BotMainPanel_Tab.Text = "پنل";
            this.BotMainPanel_Tab.UseVisualStyleBackColor = true;
            // 
            // BotStartStop_Botton
            // 
            this.BotStartStop_Botton.BackColor = System.Drawing.Color.Orange;
            this.BotStartStop_Botton.Location = new System.Drawing.Point(8, 294);
            this.BotStartStop_Botton.Name = "BotStartStop_Botton";
            this.BotStartStop_Botton.Size = new System.Drawing.Size(590, 35);
            this.BotStartStop_Botton.TabIndex = 2;
            this.BotStartStop_Botton.Text = "اتصال";
            this.BotStartStop_Botton.UseVisualStyleBackColor = false;
            this.BotStartStop_Botton.Click += new System.EventHandler(this.BotStartStop_Botton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "وضعیت ربات ";
            // 
            // BotStatus_ListBox
            // 
            this.BotStatus_ListBox.FormattingEnabled = true;
            this.BotStatus_ListBox.ItemHeight = 20;
            this.BotStatus_ListBox.Location = new System.Drawing.Point(8, 27);
            this.BotStatus_ListBox.Name = "BotStatus_ListBox";
            this.BotStatus_ListBox.Size = new System.Drawing.Size(590, 264);
            this.BotStatus_ListBox.TabIndex = 0;
            // 
            // BotSetting_Tab
            // 
            this.BotSetting_Tab.Controls.Add(this.Proxy_GroupBox);
            this.BotSetting_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BotSetting_Tab.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BotSetting_Tab.Location = new System.Drawing.Point(4, 22);
            this.BotSetting_Tab.Name = "BotSetting_Tab";
            this.BotSetting_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.BotSetting_Tab.Size = new System.Drawing.Size(606, 334);
            this.BotSetting_Tab.TabIndex = 1;
            this.BotSetting_Tab.Text = "تنظیمات";
            this.BotSetting_Tab.UseVisualStyleBackColor = true;
            // 
            // Proxy_GroupBox
            // 
            this.Proxy_GroupBox.Controls.Add(this.ProxyTest_Bottun);
            this.Proxy_GroupBox.Controls.Add(this.ProxySet_Bottun);
            this.Proxy_GroupBox.Controls.Add(this.ProxyAuth_GpBox);
            this.Proxy_GroupBox.Controls.Add(this.ProxyProtocol_GpBox);
            this.Proxy_GroupBox.Controls.Add(this.ProxyServer_GpBox);
            this.Proxy_GroupBox.Location = new System.Drawing.Point(8, 6);
            this.Proxy_GroupBox.Name = "Proxy_GroupBox";
            this.Proxy_GroupBox.Size = new System.Drawing.Size(590, 322);
            this.Proxy_GroupBox.TabIndex = 0;
            this.Proxy_GroupBox.TabStop = false;
            this.Proxy_GroupBox.Text = "پروکسی";
            // 
            // ProxyTest_Bottun
            // 
            this.ProxyTest_Bottun.Location = new System.Drawing.Point(6, 282);
            this.ProxyTest_Bottun.Name = "ProxyTest_Bottun";
            this.ProxyTest_Bottun.Size = new System.Drawing.Size(135, 30);
            this.ProxyTest_Bottun.TabIndex = 2;
            this.ProxyTest_Bottun.Text = "تست پروکسی ";
            this.ProxyTest_Bottun.UseVisualStyleBackColor = true;
            // 
            // ProxySet_Bottun
            // 
            this.ProxySet_Bottun.Location = new System.Drawing.Point(147, 282);
            this.ProxySet_Bottun.Name = "ProxySet_Bottun";
            this.ProxySet_Bottun.Size = new System.Drawing.Size(437, 30);
            this.ProxySet_Bottun.TabIndex = 2;
            this.ProxySet_Bottun.Text = "اعمال پروکسی ";
            this.ProxySet_Bottun.UseVisualStyleBackColor = true;
            // 
            // ProxyAuth_GpBox
            // 
            this.ProxyAuth_GpBox.Controls.Add(this.label4);
            this.ProxyAuth_GpBox.Controls.Add(this.label3);
            this.ProxyAuth_GpBox.Controls.Add(this.ProxyAuthPassword_TextBox);
            this.ProxyAuth_GpBox.Controls.Add(this.ProxyAuthUserName_TextBox);
            this.ProxyAuth_GpBox.Controls.Add(this.ProxyAuth_CheckBox);
            this.ProxyAuth_GpBox.Location = new System.Drawing.Point(6, 185);
            this.ProxyAuth_GpBox.Name = "ProxyAuth_GpBox";
            this.ProxyAuth_GpBox.Size = new System.Drawing.Size(578, 86);
            this.ProxyAuth_GpBox.TabIndex = 1;
            this.ProxyAuth_GpBox.TabStop = false;
            this.ProxyAuth_GpBox.Text = "نام کاربری رمز عبور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "کلمه عبور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "نام کاربری";
            // 
            // ProxyAuthPassword_TextBox
            // 
            this.ProxyAuthPassword_TextBox.Enabled = false;
            this.ProxyAuthPassword_TextBox.Location = new System.Drawing.Point(31, 36);
            this.ProxyAuthPassword_TextBox.Name = "ProxyAuthPassword_TextBox";
            this.ProxyAuthPassword_TextBox.Size = new System.Drawing.Size(100, 28);
            this.ProxyAuthPassword_TextBox.TabIndex = 1;
            // 
            // ProxyAuthUserName_TextBox
            // 
            this.ProxyAuthUserName_TextBox.Enabled = false;
            this.ProxyAuthUserName_TextBox.Location = new System.Drawing.Point(219, 34);
            this.ProxyAuthUserName_TextBox.Name = "ProxyAuthUserName_TextBox";
            this.ProxyAuthUserName_TextBox.Size = new System.Drawing.Size(100, 28);
            this.ProxyAuthUserName_TextBox.TabIndex = 1;
            // 
            // ProxyAuth_CheckBox
            // 
            this.ProxyAuth_CheckBox.AutoSize = true;
            this.ProxyAuth_CheckBox.Location = new System.Drawing.Point(447, 36);
            this.ProxyAuth_CheckBox.Name = "ProxyAuth_CheckBox";
            this.ProxyAuth_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProxyAuth_CheckBox.Size = new System.Drawing.Size(81, 24);
            this.ProxyAuth_CheckBox.TabIndex = 0;
            this.ProxyAuth_CheckBox.Text = "فعال سازی ";
            this.ProxyAuth_CheckBox.UseVisualStyleBackColor = true;
            this.ProxyAuth_CheckBox.CheckedChanged += new System.EventHandler(this.ProxyAuth_CheckBox_CheckedChanged);
            // 
            // ProxyProtocol_GpBox
            // 
            this.ProxyProtocol_GpBox.Controls.Add(this.ProxyProtocolSocks5_RadioButton);
            this.ProxyProtocol_GpBox.Controls.Add(this.ProxyProtocolSocks4_RadioButton);
            this.ProxyProtocol_GpBox.Controls.Add(this.ProxyProtocolHttps_RadioButton);
            this.ProxyProtocol_GpBox.Location = new System.Drawing.Point(6, 113);
            this.ProxyProtocol_GpBox.Name = "ProxyProtocol_GpBox";
            this.ProxyProtocol_GpBox.Size = new System.Drawing.Size(578, 66);
            this.ProxyProtocol_GpBox.TabIndex = 1;
            this.ProxyProtocol_GpBox.TabStop = false;
            this.ProxyProtocol_GpBox.Text = "پروتکل";
            // 
            // ProxyProtocolSocks5_RadioButton
            // 
            this.ProxyProtocolSocks5_RadioButton.AutoSize = true;
            this.ProxyProtocolSocks5_RadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProxyProtocolSocks5_RadioButton.Location = new System.Drawing.Point(447, 27);
            this.ProxyProtocolSocks5_RadioButton.Name = "ProxyProtocolSocks5_RadioButton";
            this.ProxyProtocolSocks5_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProxyProtocolSocks5_RadioButton.Size = new System.Drawing.Size(92, 20);
            this.ProxyProtocolSocks5_RadioButton.TabIndex = 0;
            this.ProxyProtocolSocks5_RadioButton.TabStop = true;
            this.ProxyProtocolSocks5_RadioButton.Text = "SOCKS V5";
            this.ProxyProtocolSocks5_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ProxyProtocolSocks4_RadioButton
            // 
            this.ProxyProtocolSocks4_RadioButton.AutoSize = true;
            this.ProxyProtocolSocks4_RadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProxyProtocolSocks4_RadioButton.Location = new System.Drawing.Point(335, 27);
            this.ProxyProtocolSocks4_RadioButton.Name = "ProxyProtocolSocks4_RadioButton";
            this.ProxyProtocolSocks4_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProxyProtocolSocks4_RadioButton.Size = new System.Drawing.Size(92, 20);
            this.ProxyProtocolSocks4_RadioButton.TabIndex = 0;
            this.ProxyProtocolSocks4_RadioButton.TabStop = true;
            this.ProxyProtocolSocks4_RadioButton.Text = "SOCKS V4";
            this.ProxyProtocolSocks4_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ProxyProtocolHttps_RadioButton
            // 
            this.ProxyProtocolHttps_RadioButton.AutoSize = true;
            this.ProxyProtocolHttps_RadioButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ProxyProtocolHttps_RadioButton.Location = new System.Drawing.Point(244, 27);
            this.ProxyProtocolHttps_RadioButton.Name = "ProxyProtocolHttps_RadioButton";
            this.ProxyProtocolHttps_RadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProxyProtocolHttps_RadioButton.Size = new System.Drawing.Size(67, 20);
            this.ProxyProtocolHttps_RadioButton.TabIndex = 0;
            this.ProxyProtocolHttps_RadioButton.TabStop = true;
            this.ProxyProtocolHttps_RadioButton.Text = "HTTPS";
            this.ProxyProtocolHttps_RadioButton.UseVisualStyleBackColor = true;
            // 
            // ProxyServer_GpBox
            // 
            this.ProxyServer_GpBox.Controls.Add(this.label2);
            this.ProxyServer_GpBox.Controls.Add(this.label1);
            this.ProxyServer_GpBox.Controls.Add(this.ProxyServerProt_TextBox);
            this.ProxyServer_GpBox.Controls.Add(this.ProxyServerAddress_TextBox);
            this.ProxyServer_GpBox.Location = new System.Drawing.Point(6, 27);
            this.ProxyServer_GpBox.Name = "ProxyServer_GpBox";
            this.ProxyServer_GpBox.Size = new System.Drawing.Size(578, 80);
            this.ProxyServer_GpBox.TabIndex = 1;
            this.ProxyServer_GpBox.TabStop = false;
            this.ProxyServer_GpBox.Text = "سرور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "پورت : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "آدرس : ";
            // 
            // ProxyServerProt_TextBox
            // 
            this.ProxyServerProt_TextBox.Location = new System.Drawing.Point(201, 27);
            this.ProxyServerProt_TextBox.Name = "ProxyServerProt_TextBox";
            this.ProxyServerProt_TextBox.Size = new System.Drawing.Size(71, 28);
            this.ProxyServerProt_TextBox.TabIndex = 0;
            // 
            // ProxyServerAddress_TextBox
            // 
            this.ProxyServerAddress_TextBox.Location = new System.Drawing.Point(345, 27);
            this.ProxyServerAddress_TextBox.Name = "ProxyServerAddress_TextBox";
            this.ProxyServerAddress_TextBox.Size = new System.Drawing.Size(164, 28);
            this.ProxyServerAddress_TextBox.TabIndex = 0;
            // 
            // UpdateChecker_Timer
            // 
            this.UpdateChecker_Timer.Interval = 500;
            this.UpdateChecker_Timer.Tick += new System.EventHandler(this.UpdateChecker_Timer_Tick);
            // 
            // TelegramBotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 359);
            this.Controls.Add(this.BotTabControl);
            this.Name = "TelegramBotPanel";
            this.Text = "پنل ربات رادشید";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelegramBotPanel_FormClosing);
            this.BotTabControl.ResumeLayout(false);
            this.BotMainPanel_Tab.ResumeLayout(false);
            this.BotMainPanel_Tab.PerformLayout();
            this.BotSetting_Tab.ResumeLayout(false);
            this.Proxy_GroupBox.ResumeLayout(false);
            this.ProxyAuth_GpBox.ResumeLayout(false);
            this.ProxyAuth_GpBox.PerformLayout();
            this.ProxyProtocol_GpBox.ResumeLayout(false);
            this.ProxyProtocol_GpBox.PerformLayout();
            this.ProxyServer_GpBox.ResumeLayout(false);
            this.ProxyServer_GpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl BotTabControl;
        private System.Windows.Forms.TabPage BotMainPanel_Tab;
        private System.Windows.Forms.TabPage BotSetting_Tab;
        private System.Windows.Forms.GroupBox Proxy_GroupBox;
        private System.Windows.Forms.GroupBox ProxyAuth_GpBox;
        private System.Windows.Forms.GroupBox ProxyProtocol_GpBox;
        private System.Windows.Forms.RadioButton ProxyProtocolSocks5_RadioButton;
        private System.Windows.Forms.RadioButton ProxyProtocolSocks4_RadioButton;
        private System.Windows.Forms.RadioButton ProxyProtocolHttps_RadioButton;
        private System.Windows.Forms.GroupBox ProxyServer_GpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProxyServerProt_TextBox;
        private System.Windows.Forms.TextBox ProxyServerAddress_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProxyAuthPassword_TextBox;
        private System.Windows.Forms.TextBox ProxyAuthUserName_TextBox;
        private System.Windows.Forms.CheckBox ProxyAuth_CheckBox;
        private System.Windows.Forms.Button ProxyTest_Bottun;
        private System.Windows.Forms.Button ProxySet_Bottun;
        private System.Windows.Forms.Button BotStartStop_Botton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox BotStatus_ListBox;
        private System.Windows.Forms.Timer UpdateChecker_Timer;
    }
}