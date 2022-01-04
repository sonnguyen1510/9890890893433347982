namespace Final_project
{
    partial class Kế_Toán_Form
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
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ThanhToán_EndDay = new System.Windows.Forms.DateTimePicker();
            this.ThanhToán_StartDay = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.KếToán_HóaĐơn_TB = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MặtHàng_Endday = new System.Windows.Forms.DateTimePicker();
            this.MặtHàng_StartDay = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Main_refesh = new System.Windows.Forms.Button();
            this.KếToán_MặtHàng_TB = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KếToán_HóaĐơn_TB)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KếToán_MặtHàng_TB)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.càiĐặtToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(268, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.thoátToolStripMenuItem1.Text = "Thoát Ứng Dụng";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(129, 36);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 23);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.ThanhToán_EndDay);
            this.tabPage5.Controls.Add(this.ThanhToán_StartDay);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button16);
            this.tabPage5.Controls.Add(this.KếToán_HóaĐơn_TB);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1166, 382);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Thông Tin Hóa Đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(993, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(989, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // ThanhToán_EndDay
            // 
            this.ThanhToán_EndDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThanhToán_EndDay.Location = new System.Drawing.Point(974, 249);
            this.ThanhToán_EndDay.Name = "ThanhToán_EndDay";
            this.ThanhToán_EndDay.Size = new System.Drawing.Size(146, 26);
            this.ThanhToán_EndDay.TabIndex = 25;
            this.ThanhToán_EndDay.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            // 
            // ThanhToán_StartDay
            // 
            this.ThanhToán_StartDay.CustomFormat = "";
            this.ThanhToán_StartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ThanhToán_StartDay.Location = new System.Drawing.Point(974, 191);
            this.ThanhToán_StartDay.Name = "ThanhToán_StartDay";
            this.ThanhToán_StartDay.Size = new System.Drawing.Size(146, 26);
            this.ThanhToán_StartDay.TabIndex = 24;
            this.ThanhToán_StartDay.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            this.ThanhToán_StartDay.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xuất Thống Kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(997, 44);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(95, 31);
            this.button16.TabIndex = 22;
            this.button16.Text = "Refresh";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // KếToán_HóaĐơn_TB
            // 
            this.KếToán_HóaĐơn_TB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KếToán_HóaĐơn_TB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KếToán_HóaĐơn_TB.Location = new System.Drawing.Point(3, 3);
            this.KếToán_HóaĐơn_TB.Name = "KếToán_HóaĐơn_TB";
            this.KếToán_HóaĐơn_TB.RowHeadersWidth = 62;
            this.KếToán_HóaĐơn_TB.RowTemplate.Height = 28;
            this.KếToán_HóaĐơn_TB.Size = new System.Drawing.Size(930, 373);
            this.KếToán_HóaĐơn_TB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(974, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 2);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.MặtHàng_Endday);
            this.tabPage1.Controls.Add(this.MặtHàng_StartDay);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Main_refesh);
            this.tabPage1.Controls.Add(this.KếToán_MặtHàng_TB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1166, 382);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Thông Tin Mặt Hàng";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(989, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // MặtHàng_Endday
            // 
            this.MặtHàng_Endday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MặtHàng_Endday.Location = new System.Drawing.Point(974, 249);
            this.MặtHàng_Endday.Name = "MặtHàng_Endday";
            this.MặtHàng_Endday.Size = new System.Drawing.Size(146, 26);
            this.MặtHàng_Endday.TabIndex = 14;
            this.MặtHàng_Endday.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            // 
            // MặtHàng_StartDay
            // 
            this.MặtHàng_StartDay.CustomFormat = "";
            this.MặtHàng_StartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MặtHàng_StartDay.Location = new System.Drawing.Point(974, 191);
            this.MặtHàng_StartDay.Name = "MặtHàng_StartDay";
            this.MặtHàng_StartDay.Size = new System.Drawing.Size(146, 26);
            this.MặtHàng_StartDay.TabIndex = 13;
            this.MặtHàng_StartDay.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            this.MặtHàng_StartDay.ValueChanged += new System.EventHandler(this.MặtHàng_StartDay_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(964, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Thông Tin Chi Tiết";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Xuất Đơn Nhập Hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_refesh
            // 
            this.Main_refesh.Location = new System.Drawing.Point(997, 44);
            this.Main_refesh.Name = "Main_refesh";
            this.Main_refesh.Size = new System.Drawing.Size(95, 31);
            this.Main_refesh.TabIndex = 10;
            this.Main_refesh.Text = "Refresh";
            this.Main_refesh.UseVisualStyleBackColor = true;
            this.Main_refesh.Click += new System.EventHandler(this.Main_refesh_Click);
            // 
            // KếToán_MặtHàng_TB
            // 
            this.KếToán_MặtHàng_TB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KếToán_MặtHàng_TB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KếToán_MặtHàng_TB.Location = new System.Drawing.Point(3, 3);
            this.KếToán_MặtHàng_TB.Name = "KếToán_MặtHàng_TB";
            this.KếToán_MặtHàng_TB.RowHeadersWidth = 62;
            this.KếToán_MặtHàng_TB.RowTemplate.Height = 28;
            this.KếToán_MặtHàng_TB.Size = new System.Drawing.Size(930, 373);
            this.KếToán_MặtHàng_TB.TabIndex = 0;
            this.KếToán_MặtHàng_TB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KếToán_MặtHàng_TB_CellContentClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(974, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 2);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(10, 36);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1174, 415);
            this.tabControl2.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(964, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 31);
            this.button4.TabIndex = 28;
            this.button4.Text = "Thông Tin Chi Tiết";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kế_Toán_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 472);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kế_Toán_Form";
            this.Text = "Kế Toán";
            this.Load += new System.EventHandler(this.Kế_Toán_Form_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KếToán_HóaĐơn_TB)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KếToán_MặtHàng_TB)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.DataGridView KếToán_HóaĐơn_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Main_refesh;
        private System.Windows.Forms.DataGridView KếToán_MặtHàng_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker MặtHàng_Endday;
        private System.Windows.Forms.DateTimePicker MặtHàng_StartDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ThanhToán_EndDay;
        private System.Windows.Forms.DateTimePicker ThanhToán_StartDay;
        private System.Windows.Forms.Button button4;
    }
}