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
            this.UpdateChecker_Timer = new System.Windows.Forms.Timer(this.components);
            this.BotStop_Botton = new System.Windows.Forms.Button();
            this.BotStart_Botton = new System.Windows.Forms.Button();
            this.BotStatus_ListBox = new System.Windows.Forms.ListBox();
            this.ReStartBot_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UpdateChecker_Timer
            // 
            this.UpdateChecker_Timer.Interval = 1000;
            this.UpdateChecker_Timer.Tick += new System.EventHandler(this.UpdateChecker_Timer_Tick);
            // 
            // BotStop_Botton
            // 
            this.BotStop_Botton.BackColor = System.Drawing.Color.Peru;
            this.BotStop_Botton.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStop_Botton.Location = new System.Drawing.Point(12, 301);
            this.BotStop_Botton.Name = "BotStop_Botton";
            this.BotStop_Botton.Size = new System.Drawing.Size(131, 35);
            this.BotStop_Botton.TabIndex = 5;
            this.BotStop_Botton.Text = "توقف ربات";
            this.BotStop_Botton.UseVisualStyleBackColor = false;
            this.BotStop_Botton.Click += new System.EventHandler(this.BotStop_Botton_Click);
            // 
            // BotStart_Botton
            // 
            this.BotStart_Botton.BackColor = System.Drawing.Color.Orange;
            this.BotStart_Botton.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStart_Botton.Location = new System.Drawing.Point(149, 301);
            this.BotStart_Botton.Name = "BotStart_Botton";
            this.BotStart_Botton.Size = new System.Drawing.Size(933, 35);
            this.BotStart_Botton.TabIndex = 4;
            this.BotStart_Botton.Text = "اتصال";
            this.BotStart_Botton.UseVisualStyleBackColor = false;
            this.BotStart_Botton.Click += new System.EventHandler(this.BotStart_Botton_Click);
            // 
            // BotStatus_ListBox
            // 
            this.BotStatus_ListBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStatus_ListBox.FormattingEnabled = true;
            this.BotStatus_ListBox.ItemHeight = 21;
            this.BotStatus_ListBox.Location = new System.Drawing.Point(12, 22);
            this.BotStatus_ListBox.Name = "BotStatus_ListBox";
            this.BotStatus_ListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotStatus_ListBox.Size = new System.Drawing.Size(1073, 277);
            this.BotStatus_ListBox.TabIndex = 3;
            // 
            // ReStartBot_timer
            // 
            this.ReStartBot_timer.Interval = 1000;
            this.ReStartBot_timer.Tick += new System.EventHandler(this.ReStartBot_timer_Tick);
            // 
            // TelegramBotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 359);
            this.Controls.Add(this.BotStop_Botton);
            this.Controls.Add(this.BotStart_Botton);
            this.Controls.Add(this.BotStatus_ListBox);
            this.Name = "TelegramBotPanel";
            this.Text = "پنل ربات رادشید";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelegramBotPanel_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer UpdateChecker_Timer;
        private System.Windows.Forms.Button BotStop_Botton;
        private System.Windows.Forms.Button BotStart_Botton;
        private System.Windows.Forms.ListBox BotStatus_ListBox;
        private System.Windows.Forms.Timer ReStartBot_timer;
    }
}