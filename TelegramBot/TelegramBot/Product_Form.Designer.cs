namespace TelegramBot
{
    partial class Product_Form
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
            this.Product_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Product_name_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Product_Button = new System.Windows.Forms.Button();
            this.Delete_Product_Button = new System.Windows.Forms.Button();
            this.Save_Product_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_listBox
            // 
            this.Product_listBox.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_listBox.FormattingEnabled = true;
            this.Product_listBox.ItemHeight = 17;
            this.Product_listBox.Location = new System.Drawing.Point(18, 109);
            this.Product_listBox.Name = "Product_listBox";
            this.Product_listBox.Size = new System.Drawing.Size(156, 157);
            this.Product_listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام محصول";
            // 
            // Product_name_TextBox
            // 
            this.Product_name_TextBox.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_name_TextBox.Location = new System.Drawing.Point(18, 35);
            this.Product_name_TextBox.Name = "Product_name_TextBox";
            this.Product_name_TextBox.Size = new System.Drawing.Size(156, 25);
            this.Product_name_TextBox.TabIndex = 2;
            // 
            // Add_Product_Button
            // 
            this.Add_Product_Button.BackColor = System.Drawing.Color.OliveDrab;
            this.Add_Product_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Product_Button.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product_Button.Location = new System.Drawing.Point(34, 66);
            this.Add_Product_Button.Name = "Add_Product_Button";
            this.Add_Product_Button.Size = new System.Drawing.Size(126, 26);
            this.Add_Product_Button.TabIndex = 3;
            this.Add_Product_Button.Text = "افزودن";
            this.Add_Product_Button.UseVisualStyleBackColor = false;
            this.Add_Product_Button.Click += new System.EventHandler(this.Add_Product_Button_Click);
            // 
            // Delete_Product_Button
            // 
            this.Delete_Product_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Delete_Product_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Product_Button.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Product_Button.Location = new System.Drawing.Point(34, 272);
            this.Delete_Product_Button.Name = "Delete_Product_Button";
            this.Delete_Product_Button.Size = new System.Drawing.Size(126, 23);
            this.Delete_Product_Button.TabIndex = 3;
            this.Delete_Product_Button.Text = "حذف";
            this.Delete_Product_Button.UseVisualStyleBackColor = false;
            this.Delete_Product_Button.Click += new System.EventHandler(this.Delete_Product_Button_Click);
            // 
            // Save_Product_Button
            // 
            this.Save_Product_Button.BackColor = System.Drawing.Color.Silver;
            this.Save_Product_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Product_Button.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Product_Button.Location = new System.Drawing.Point(-4, 309);
            this.Save_Product_Button.Name = "Save_Product_Button";
            this.Save_Product_Button.Size = new System.Drawing.Size(200, 40);
            this.Save_Product_Button.TabIndex = 3;
            this.Save_Product_Button.Text = "ذخیره";
            this.Save_Product_Button.UseVisualStyleBackColor = false;
            this.Save_Product_Button.Click += new System.EventHandler(this.Save_Product_Button_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(193, 350);
            this.Controls.Add(this.Save_Product_Button);
            this.Controls.Add(this.Delete_Product_Button);
            this.Controls.Add(this.Add_Product_Button);
            this.Controls.Add(this.Product_name_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Product_listBox);
            this.Name = "Product_Form";
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Product_listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Product_name_TextBox;
        private System.Windows.Forms.Button Add_Product_Button;
        private System.Windows.Forms.Button Delete_Product_Button;
        private System.Windows.Forms.Button Save_Product_Button;
    }
}