
namespace Final_project
{
    partial class QuênMậtKhẩu_Form
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
            this.label5 = new System.Windows.Forms.Label();
            this.ĐăngNhập_LoginButton = new System.Windows.Forms.Button();
            this.QuênMK_nhậpTài_khoản = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuênMK_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Design by sonnguyen";
            // 
            // ĐăngNhập_LoginButton
            // 
            this.ĐăngNhập_LoginButton.Location = new System.Drawing.Point(236, 197);
            this.ĐăngNhập_LoginButton.Name = "ĐăngNhập_LoginButton";
            this.ĐăngNhập_LoginButton.Size = new System.Drawing.Size(184, 36);
            this.ĐăngNhập_LoginButton.TabIndex = 14;
            this.ĐăngNhập_LoginButton.Text = "Xác nhận tài khoản";
            this.ĐăngNhập_LoginButton.UseVisualStyleBackColor = true;
            this.ĐăngNhập_LoginButton.Click += new System.EventHandler(this.ĐăngNhập_LoginButton_Click);
            // 
            // QuênMK_nhậpTài_khoản
            // 
            this.QuênMK_nhậpTài_khoản.Location = new System.Drawing.Point(236, 145);
            this.QuênMK_nhậpTài_khoản.Name = "QuênMK_nhậpTài_khoản";
            this.QuênMK_nhậpTài_khoản.Size = new System.Drawing.Size(257, 26);
            this.QuênMK_nhậpTài_khoản.TabIndex = 12;
            this.QuênMK_nhậpTài_khoản.TextChanged += new System.EventHandler(this.ĐăngNhập_nhậpTài_khoản_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(107, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vui lòng nhập tài khoản :";
            // 
            // QuênMK_title
            // 
            this.QuênMK_title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QuênMK_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.QuênMK_title.Location = new System.Drawing.Point(105, 9);
            this.QuênMK_title.Name = "QuênMK_title";
            this.QuênMK_title.Size = new System.Drawing.Size(388, 89);
            this.QuênMK_title.TabIndex = 9;
            this.QuênMK_title.Text = "QUÊN MẬT KHẨU";
            this.QuênMK_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuênMK_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(232, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Trở về trang đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // QuênMậtKhẩu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ĐăngNhập_LoginButton);
            this.Controls.Add(this.QuênMK_nhậpTài_khoản);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuênMK_title);
            this.Name = "QuênMậtKhẩu_Form";
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.QuênMậtKhẩu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ĐăngNhập_LoginButton;
        private System.Windows.Forms.TextBox QuênMK_nhậpTài_khoản;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label QuênMK_title;
        private System.Windows.Forms.Label label1;
    }
}