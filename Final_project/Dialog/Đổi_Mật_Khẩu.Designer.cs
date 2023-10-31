namespace Bán_hàng_online_winform.Dialog
{
    partial class Đổi_Mật_Khẩu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ĐổiMK_ReNewPW = new System.Windows.Forms.TextBox();
            this.ĐổiMK_NewPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ĐổiMK_OldPW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nhập Mật Khẩu Mới";
            // 
            // ĐổiMK_ReNewPW
            // 
            this.ĐổiMK_ReNewPW.Location = new System.Drawing.Point(224, 201);
            this.ĐổiMK_ReNewPW.Name = "ĐổiMK_ReNewPW";
            this.ĐổiMK_ReNewPW.PasswordChar = '*';
            this.ĐổiMK_ReNewPW.Size = new System.Drawing.Size(204, 26);
            this.ĐổiMK_ReNewPW.TabIndex = 10;
            // 
            // ĐổiMK_NewPW
            // 
            this.ĐổiMK_NewPW.Location = new System.Drawing.Point(224, 155);
            this.ĐổiMK_NewPW.Name = "ĐổiMK_NewPW";
            this.ĐổiMK_NewPW.PasswordChar = '*';
            this.ĐổiMK_NewPW.Size = new System.Drawing.Size(204, 26);
            this.ĐổiMK_NewPW.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(158, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập Mật Khẩu Cũ";
            // 
            // ĐổiMK_OldPW
            // 
            this.ĐổiMK_OldPW.Location = new System.Drawing.Point(224, 112);
            this.ĐổiMK_OldPW.Name = "ĐổiMK_OldPW";
            this.ĐổiMK_OldPW.PasswordChar = '*';
            this.ĐổiMK_OldPW.Size = new System.Drawing.Size(204, 26);
            this.ĐổiMK_OldPW.TabIndex = 15;
            // 
            // Đổi_Mật_Khẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ĐổiMK_OldPW);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ĐổiMK_ReNewPW);
            this.Controls.Add(this.ĐổiMK_NewPW);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Đổi_Mật_Khẩu";
            this.Text = "Đổi_Mật_Khẩu";
            this.Load += new System.EventHandler(this.Đổi_Mật_Khẩu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ĐổiMK_ReNewPW;
        private System.Windows.Forms.TextBox ĐổiMK_NewPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ĐổiMK_OldPW;
    }
}