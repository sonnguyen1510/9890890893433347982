using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace Bán_hàng_online_winform
{
    
    public partial class Đăng_Nhập : Form
    {
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public string Save = "";
        
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuênMậtKhẩu_Form quênMậtKhẩu = new QuênMậtKhẩu_Form();
            quênMậtKhẩu.Show();
            
        }

        public void Đăng_Nhập_Load(object sender, EventArgs e)
        {
            ĐăngNhập_nhậpTài_khoản.Text = Save;
            ĐăngNhập_Password.Text = "";
            PhầnMềmQuảnLý_LưuTK.Checked = false;
        }

        private void ĐăngNhập_LoginButton_Click(object sender, EventArgs e)
        {
            //String ConnectionString= @"Data Source=LAPTOP-VCQK61MA\SONNGUYEN;Initial Catalog = Final_project;Integrated Security=True";
            //SqlConnection cnn1;
            cnn = new SqlConnection(CNT);

            cnn.Open();

            SqlCommand cmd = new SqlCommand(
               "Select * from [User] where UserName='" + ĐăngNhập_nhậpTài_khoản.Text + "'and Password='" + ĐăngNhập_Password.Text + "' and status = 1", cnn
            );

            
            

            DataTable dt = new DataTable();
            SqlDataAdapter Login_check = new SqlDataAdapter(cmd);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Login_check.Fill(dt);
            DataRow[] dr = dt.Select("UserName='" + ĐăngNhập_nhậpTài_khoản.Text + "'");
            //Login_Check_by_email.Fill(dt);
            String UserName = "";
            //MessageBox.Show(dr[0].ToString());
            int Role = 0;

            foreach (DataRow row in dr)
            {
                UserName = row["UserName"].ToString();
                Role = int.Parse(row["Role"].ToString());

            }

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login sucess Welcome");
                //inf.Password = PW;
                //inf.UserName = UN;
                //Thread thread = new Thread(new ThreadStart(openForm2)); //Tạo luồng mới
                //thread.Start(); //Khởi chạy luồng
                
                

                if(Role == 50)
                {
                    Main open = new Main(this, UserName);
                    if (PhầnMềmQuảnLý_LưuTK.Checked)
                    {
                        Save = ĐăngNhập_nhậpTài_khoản.Text;
                        //MessageBox.Show("Active");
                    }
                    else
                    {
                        Save = "";
                    }
                    this.Hide();
                    open.ShowDialog();
                }
                
                else if(Role == 20 || Role == 30)
                {
                    Kế_Toán_Form open = new Kế_Toán_Form(this, UserName);
                    if (PhầnMềmQuảnLý_LưuTK.Checked)
                    {
                        Save = ĐăngNhập_nhậpTài_khoản.Text;
                        //MessageBox.Show("Active");
                    }
                    else
                    {
                        Save = "";
                    }
                    this.Hide();
                    open.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lạc Loài");
                }


                
                //this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }

        public void openForm2()
        {

            //inf.ShowDialog();
            Main open = new Main();
            open.Show();
        }

        private void ĐăngNhập_nhậpTài_khoản_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhầnMềmQuảnLý_LưuTK_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
