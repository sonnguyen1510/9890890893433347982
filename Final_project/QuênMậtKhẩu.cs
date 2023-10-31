using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using Bán_hàng_online_winform.Dialog;
using System.Data.SqlClient;

namespace Bán_hàng_online_winform
{
    public partial class QuênMậtKhẩu_Form : Form
    {
        public String OTP;
        public Boolean IsChangePW = false;
        private Form Return;
        public string connectionString = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;

        public QuênMậtKhẩu_Form()
        {
            InitializeComponent();
            QuênMK_title.Text = "Quên Mật Khẩu";
            
        }

        public QuênMậtKhẩu_Form(Form form)
        {
            InitializeComponent();
            QuênMK_title.Text = "Đổi Mật Khẩu";
            this.IsChangePW = true;
            this.Return = form;
        }


        private void QuênMậtKhẩu_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ĐăngNhập_nhậpTài_khoản_TextChanged(object sender, EventArgs e)
        {

        }

        private void ĐăngNhập_LoginButton_Click(object sender, EventArgs e)

        {
            string cmdString = "Select * from [User] where UserName = '"+QuênMK_nhậpTài_khoản.Text+"' and status = 1";
            //MessageBox.Show(cmdString);
            SqlCommand cmd = new SqlCommand(cmdString, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            da.Fill(dt);

            

            if (dt.Rows.Count > 0 )

            {
                DataRow[] dr = dt.Select("UserName = '" + QuênMK_nhậpTài_khoản.Text + "'");
                String Email = dr[0]["Email"].ToString();
                String UserName = dr[0]["UserName"].ToString();

                String To = QuênMK_nhậpTài_khoản.Text;
                OTP = randomcode();
                String Text = "Mã OTP của bạn là : " + OTP;
                SendEmail("Xác minh tài khoản", "Sondzai152001@gmail.com",Email , Text);
                MessageBox.Show("Đã gửi mã mã OTP đến email thành công");

                //DialogResult dia = MessageBox.Show("Vui nhập vào OTP", "Đặt Lại Mật Khẩu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DialogQuenMatKhau XácNhan = new DialogQuenMatKhau(OTP, UserName);
                this.Hide();
                XácNhan.ShowDialog();
            }
            else
            {
                DialogResult dia = MessageBox.Show("Tài khoản của bạn không tồn tại !","Confimation",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            }
        }

        public String randomcode()
        {
         
            
                Random TenBienRanDom = new Random();
                int store = TenBienRanDom.Next(111111, 999999);
               
            return store.ToString();
        }

        protected void SendEmail(string _subject, String _from, String _to, String message )
        {
            MailMessage mess = new MailMessage(_from,_to,_subject,message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("Sondzai152001@gmail.com", "1234567890Son");
            //client.Credentials = new NetworkCredential("tuananhfake310801@gmail.com", "123467890Anh");
            client.Send(mess);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (IsChangePW)
            {
                Return.Show();
                this.Close();   
            }
            else
            {
                Đăng_Nhập đăng_Nhập = new Đăng_Nhập();
                đăng_Nhập.Show();
                this.Close();
            }
        }
    }
}
