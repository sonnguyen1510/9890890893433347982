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
    public partial class Đổi_Mật_Khẩu : Form
    {
        public String UserName;
        public Form Return;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Đổi_Mật_Khẩu()
        {
            InitializeComponent();
        }

        public Đổi_Mật_Khẩu(String UserName, Form form)
        {
            InitializeComponent();
            this.UserName = UserName;
            Return = form;
        }

        private void Đổi_Mật_Khẩu_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand GetPW = new SqlCommand("Select * from [User] where UserName = '" + UserName + "'",cnn);
            SqlDataAdapter DA = new SqlDataAdapter(GetPW);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            DataRow []dr = dt.Select("UserName = '" + UserName + "'");
            
            String OLDPW = dr[0]["Password"].ToString();

            if (OLDPW == ĐổiMK_OldPW.Text)
            {
                if (ĐổiMK_NewPW.Text == ĐổiMK_ReNewPW.Text)
                {
                    cnn = new SqlConnection(CNT);
                    cnn.Open();

                    String cmdString = "Update [User] set password = '" + ĐổiMK_NewPW.Text + "' where UserName = '" + UserName + "'";
                    SqlCommand cmd = new SqlCommand(cmdString, cnn);

                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.UpdateCommand = new SqlCommand(cmdString, cnn);
                    adp.UpdateCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    cmd.Clone();
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công !");

                    Return.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng , vui lòng nhập lại !");

                }
            }
            else
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mật Khẩu , vui lòng kiểm tra lại !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return.Show();
            this.Close();
        }
    }
}
