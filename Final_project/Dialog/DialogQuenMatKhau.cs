using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_hàng_online_winform.Dialog
{
    public partial class DialogQuenMatKhau : Form
    {
        public String OTP;
        public String UserName;
        public DialogQuenMatKhau()
        {
            InitializeComponent();
        }

        public DialogQuenMatKhau(String OTP , String UserName)
        {
            InitializeComponent();
            this.OTP = OTP;
            this.UserName = UserName;
        }

        private void DialogQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.OTP == XácNhận_GetOTP.Text)
            {
                //String UserName = UserName;
                ĐặtLạiMậtKhẩu reLife = new ĐặtLạiMậtKhẩu(UserName);
                reLife.Show();
                this.Close();
            }
            else
            {
                DialogResult dia = MessageBox.Show("Bạn đã nhập sai OTP", "Confimation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XácNhận_GetOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void XácNhận_Cancel_button_Click(object sender, EventArgs e)
        {
            //Phần_mềm_quản_lý 
        }
    }
}
