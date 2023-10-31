
namespace Bán_hàng_online_winform
{
    partial class Đăng_Nhập
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ĐăngNhập_nhậpTài_khoản = new System.Windows.Forms.TextBox();
            this.ĐăngNhập_Password = new System.Windows.Forms.TextBox();
            this.ĐăngNhập_LoginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhầnMềmQuảnLý_LưuTK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(132, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(134, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản hoặc số điện thoại :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(131, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu :";
            // 
            // ĐăngNhập_nhậpTài_khoản
            // 
            this.ĐăngNhập_nhậpTài_khoản.Location = new System.Drawing.Point(263, 164);
            this.ĐăngNhập_nhậpTài_khoản.Name = "ĐăngNhập_nhậpTài_khoản";
            this.ĐăngNhập_nhậpTài_khoản.Size = new System.Drawing.Size(257, 26);
            this.ĐăngNhập_nhậpTài_khoản.TabIndex = 3;
            this.ĐăngNhập_nhậpTài_khoản.TextChanged += new System.EventHandler(this.ĐăngNhập_nhậpTài_khoản_TextChanged);
            // 
            // ĐăngNhập_Password
            // 
            this.ĐăngNhập_Password.Location = new System.Drawing.Point(263, 230);
            this.ĐăngNhập_Password.Name = "ĐăngNhập_Password";
            this.ĐăngNhập_Password.PasswordChar = '*';
            this.ĐăngNhập_Password.Size = new System.Drawing.Size(257, 26);
            this.ĐăngNhập_Password.TabIndex = 4;
            // 
            // ĐăngNhập_LoginButton
            // 
            this.ĐăngNhập_LoginButton.Location = new System.Drawing.Point(263, 304);
            this.ĐăngNhập_LoginButton.Name = "ĐăngNhập_LoginButton";
            this.ĐăngNhập_LoginButton.Size = new System.Drawing.Size(127, 36);
            this.ĐăngNhập_LoginButton.TabIndex = 5;
            this.ĐăngNhập_LoginButton.Text = "Đăng Nhập";
            this.ĐăngNhập_LoginButton.UseVisualStyleBackColor = true;
            this.ĐăngNhập_LoginButton.Click += new System.EventHandler(this.ĐăngNhập_LoginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(259, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quên mật khẩu ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Design by sonnguyen";
            // 
            // PhầnMềmQuảnLý_LưuTK
            // 
            this.PhầnMềmQuảnLý_LưuTK.AutoSize = true;
            this.PhầnMềmQuảnLý_LưuTK.Location = new System.Drawing.Point(263, 263);
            this.PhầnMềmQuảnLý_LưuTK.Name = "PhầnMềmQuảnLý_LưuTK";
            this.PhầnMềmQuảnLý_LưuTK.Size = new System.Drawing.Size(131, 24);
            this.PhầnMềmQuảnLý_LưuTK.TabIndex = 9;
            this.PhầnMềmQuảnLý_LưuTK.Text = "Lưu tài khoản";
            this.PhầnMềmQuảnLý_LưuTK.UseVisualStyleBackColor = true;
            this.PhầnMềmQuảnLý_LưuTK.CheckedChanged += new System.EventHandler(this.PhầnMềmQuảnLý_LưuTK_CheckedChanged);
            // 
            // Đăng_Nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 451);
            this.Controls.Add(this.PhầnMềmQuảnLý_LưuTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ĐăngNhập_LoginButton);
            this.Controls.Add(this.ĐăngNhập_Password);
            this.Controls.Add(this.ĐăngNhập_nhậpTài_khoản);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Đăng_Nhập";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Đăng_Nhập_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ĐăngNhập_nhậpTài_khoản;
        private System.Windows.Forms.TextBox ĐăngNhập_Password;
        private System.Windows.Forms.Button ĐăngNhập_LoginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox PhầnMềmQuảnLý_LưuTK;
    }
}