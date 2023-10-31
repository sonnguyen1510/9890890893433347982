using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bán_hàng_online_winform.Dialog
{
    public partial class ĐặtLạiMậtKhẩu : Form
    {
        private string UserName;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;

        public ĐặtLạiMậtKhẩu()
        {
            InitializeComponent();
        }

        public ĐặtLạiMậtKhẩu(string UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ĐặtLạiMậtKhẩu_CheckPW_ip.Text == ĐặtLạiMậtKhẩu_NewPW_ip.Text)
            {
                cnn = new SqlConnection(CNT);
                cnn.Open();

                String cmdString = "Update [User] set password = '"+ĐặtLạiMậtKhẩu_NewPW_ip.Text+ "' where UserName = '" + UserName+"'";
                SqlCommand cmd = new SqlCommand(cmdString, cnn);

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.UpdateCommand = new SqlCommand(cmdString,cnn);
                adp.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Clone();

                MessageBox.Show("Bạn đã lấy lại mật khẩu thành công !");
                Đăng_Nhập returnQL = new Đăng_Nhập();
                returnQL.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng , vui lòng nhập lại !");

            }
        }

        private void ĐặtLạiMậtKhẩu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
