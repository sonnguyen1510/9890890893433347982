namespace Final_project.Dialog
{
    partial class DialogQuenMatKhau
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
            this.XácNhận_GetOTP = new System.Windows.Forms.TextBox();
            this.XácNhận_Gửilại_button = new System.Windows.Forms.Button();
            this.XácNhận_XácNhận_button = new System.Windows.Forms.Button();
            this.XácNhận_Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(115, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mã OTP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "OTP:";
            // 
            // XácNhận_GetOTP
            // 
            this.XácNhận_GetOTP.Location = new System.Drawing.Point(139, 109);
            this.XácNhận_GetOTP.Name = "XácNhận_GetOTP";
            this.XácNhận_GetOTP.Size = new System.Drawing.Size(223, 26);
            this.XácNhận_GetOTP.TabIndex = 2;
            this.XácNhận_GetOTP.TextChanged += new System.EventHandler(this.XácNhận_GetOTP_TextChanged);
            // 
            // XácNhận_Gửilại_button
            // 
            this.XácNhận_Gửilại_button.Location = new System.Drawing.Point(258, 158);
            this.XácNhận_Gửilại_button.Name = "XácNhận_Gửilại_button";
            this.XácNhận_Gửilại_button.Size = new System.Drawing.Size(104, 29);
            this.XácNhận_Gửilại_button.TabIndex = 3;
            this.XácNhận_Gửilại_button.Text = "Gửi lại mã";
            this.XácNhận_Gửilại_button.UseVisualStyleBackColor = true;
            // 
            // XácNhận_XácNhận_button
            // 
            this.XácNhận_XácNhận_button.Location = new System.Drawing.Point(139, 158);
            this.XácNhận_XácNhận_button.Name = "XácNhận_XácNhận_button";
            this.XácNhận_XácNhận_button.Size = new System.Drawing.Size(113, 65);
            this.XácNhận_XácNhận_button.TabIndex = 4;
            this.XácNhận_XácNhận_button.Text = "Xác Nhận";
            this.XácNhận_XácNhận_button.UseVisualStyleBackColor = true;
            this.XácNhận_XácNhận_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // XácNhận_Cancel_button
            // 
            this.XácNhận_Cancel_button.Location = new System.Drawing.Point(259, 194);
            this.XácNhận_Cancel_button.Name = "XácNhận_Cancel_button";
            this.XácNhận_Cancel_button.Size = new System.Drawing.Size(103, 29);
            this.XácNhận_Cancel_button.TabIndex = 5;
            this.XácNhận_Cancel_button.Text = "Cancel";
            this.XácNhận_Cancel_button.UseVisualStyleBackColor = true;
            this.XácNhận_Cancel_button.Click += new System.EventHandler(this.XácNhận_Cancel_button_Click);
            // 
            // DialogQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 314);
            this.ControlBox = false;
            this.Controls.Add(this.XácNhận_Cancel_button);
            this.Controls.Add(this.XácNhận_XácNhận_button);
            this.Controls.Add(this.XácNhận_Gửilại_button);
            this.Controls.Add(this.XácNhận_GetOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogQuenMatKhau";
            this.Text = "Xác Nhận";
            this.Load += new System.EventHandler(this.DialogQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XácNhận_GetOTP;
        private System.Windows.Forms.Button XácNhận_Gửilại_button;
        private System.Windows.Forms.Button XácNhận_XácNhận_button;
        private System.Windows.Forms.Button XácNhận_Cancel_button;
    }
}