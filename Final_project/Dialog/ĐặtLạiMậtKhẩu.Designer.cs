namespace Bán_hàng_online_winform.Dialog
{
    partial class ĐặtLạiMậtKhẩu
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
            this.ĐặtLạiMậtKhẩu_NewPW_ip = new System.Windows.Forms.TextBox();
            this.ĐặtLạiMậtKhẩu_CheckPW_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(154, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đặt Lại Mật Khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ĐặtLạiMậtKhẩu_NewPW_ip
            // 
            this.ĐặtLạiMậtKhẩu_NewPW_ip.Location = new System.Drawing.Point(211, 102);
            this.ĐặtLạiMậtKhẩu_NewPW_ip.Name = "ĐặtLạiMậtKhẩu_NewPW_ip";
            this.ĐặtLạiMậtKhẩu_NewPW_ip.Size = new System.Drawing.Size(204, 26);
            this.ĐặtLạiMậtKhẩu_NewPW_ip.TabIndex = 2;
            // 
            // ĐặtLạiMậtKhẩu_CheckPW_ip
            // 
            this.ĐặtLạiMậtKhẩu_CheckPW_ip.Location = new System.Drawing.Point(211, 148);
            this.ĐặtLạiMậtKhẩu_CheckPW_ip.Name = "ĐặtLạiMậtKhẩu_CheckPW_ip";
            this.ĐặtLạiMậtKhẩu_CheckPW_ip.Size = new System.Drawing.Size(204, 26);
            this.ĐặtLạiMậtKhẩu_CheckPW_ip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác Nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ĐặtLạiMậtKhẩu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 304);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ĐặtLạiMậtKhẩu_CheckPW_ip);
            this.Controls.Add(this.ĐặtLạiMậtKhẩu_NewPW_ip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ĐặtLạiMậtKhẩu";
            this.Text = "Đặt Lại Mật Khẩu";
            this.Load += new System.EventHandler(this.ĐặtLạiMậtKhẩu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ĐặtLạiMậtKhẩu_NewPW_ip;
        private System.Windows.Forms.TextBox ĐặtLạiMậtKhẩu_CheckPW_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}