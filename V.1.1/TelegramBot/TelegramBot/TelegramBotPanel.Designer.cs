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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelegramBotPanel));
            this.BotStop_Botton = new System.Windows.Forms.Button();
            this.BotStart_Botton = new System.Windows.Forms.Button();
            this.BotStatus_ListBox = new System.Windows.Forms.ListBox();
            this.BackgroundWorker_GetUpdate = new System.ComponentModel.BackgroundWorker();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_Button = new System.Windows.Forms.PictureBox();
            this.Maximize_Button = new System.Windows.Forms.PictureBox();
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // BotStop_Botton
            // 
            this.BotStop_Botton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotStop_Botton.BackColor = System.Drawing.Color.Peru;
            this.BotStop_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotStop_Botton.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStop_Botton.Location = new System.Drawing.Point(12, 347);
            this.BotStop_Botton.Name = "BotStop_Botton";
            this.BotStop_Botton.Size = new System.Drawing.Size(131, 35);
            this.BotStop_Botton.TabIndex = 5;
            this.BotStop_Botton.Text = "توقف ربات";
            this.BotStop_Botton.UseVisualStyleBackColor = false;
            this.BotStop_Botton.Click += new System.EventHandler(this.BotStop_Botton_Click);
            // 
            // BotStart_Botton
            // 
            this.BotStart_Botton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotStart_Botton.BackColor = System.Drawing.Color.Orange;
            this.BotStart_Botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotStart_Botton.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStart_Botton.Location = new System.Drawing.Point(149, 347);
            this.BotStart_Botton.Name = "BotStart_Botton";
            this.BotStart_Botton.Size = new System.Drawing.Size(933, 35);
            this.BotStart_Botton.TabIndex = 4;
            this.BotStart_Botton.Text = "اتصال";
            this.BotStart_Botton.UseVisualStyleBackColor = false;
            this.BotStart_Botton.Click += new System.EventHandler(this.BotStart_Botton_Click);
            // 
            // BotStatus_ListBox
            // 
            this.BotStatus_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotStatus_ListBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotStatus_ListBox.FormattingEnabled = true;
            this.BotStatus_ListBox.ItemHeight = 21;
            this.BotStatus_ListBox.Location = new System.Drawing.Point(12, 78);
            this.BotStatus_ListBox.Name = "BotStatus_ListBox";
            this.BotStatus_ListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotStatus_ListBox.Size = new System.Drawing.Size(1073, 256);
            this.BotStatus_ListBox.TabIndex = 3;
            // 
            // BackgroundWorker_GetUpdate
            // 
            this.BackgroundWorker_GetUpdate.WorkerSupportsCancellation = true;
            this.BackgroundWorker_GetUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_GetUpdate_DoWork);
            // 
            // Menu
            // 
            this.Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("IRANSans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenuItem});
            this.Menu.Location = new System.Drawing.Point(1018, 48);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu.Size = new System.Drawing.Size(77, 27);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "menuStrip1";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Size = new System.Drawing.Size(69, 23);
            this.ProductMenuItem.Text = "محصولات";
            this.ProductMenuItem.Click += new System.EventHandler(this.ProductMenuItem_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.Location = new System.Drawing.Point(1067, 3);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(28, 28);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_Button.TabIndex = 7;
            this.Close_Button.TabStop = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Maximize_Button
            // 
            this.Maximize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_Button.Image")));
            this.Maximize_Button.Location = new System.Drawing.Point(1033, 3);
            this.Maximize_Button.Name = "Maximize_Button";
            this.Maximize_Button.Size = new System.Drawing.Size(28, 28);
            this.Maximize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize_Button.TabIndex = 7;
            this.Maximize_Button.TabStop = false;
            this.Maximize_Button.Click += new System.EventHandler(this.Maximize_Button_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Button.Image")));
            this.Minimize_Button.Location = new System.Drawing.Point(999, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(28, 28);
            this.Minimize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_Button.TabIndex = 7;
            this.Minimize_Button.TabStop = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // TelegramBotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 398);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Maximize_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.BotStop_Botton);
            this.Controls.Add(this.BotStart_Botton);
            this.Controls.Add(this.BotStatus_ListBox);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Menu;
            this.Name = "TelegramBotPanel";
            this.Text = "پنل ربات رادشید";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelegramBotPanel_FormClosing);
            this.Load += new System.EventHandler(this.TelegramBotPanel_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotStop_Botton;
        private System.Windows.Forms.Button BotStart_Botton;
        private System.Windows.Forms.ListBox BotStatus_ListBox;
        private System.ComponentModel.BackgroundWorker BackgroundWorker_GetUpdate;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ProductMenuItem;
        private System.Windows.Forms.PictureBox Close_Button;
        private System.Windows.Forms.PictureBox Maximize_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
    }
}