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

namespace Bán_hàng_online_winform
{
    public partial class Thêm_Nhân_Viên : Form
    {
        public int Role = 0;
        private Main Main;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        private int Gender = 3;

        public Thêm_Nhân_Viên()
        {
            InitializeComponent();
        }

        public Thêm_Nhân_Viên(Main main)
        {
            this.Main = main;
            InitializeComponent();
        }



        private void Thêm_Nhân_Viên_Load(object sender, EventArgs e)
        {
            //Role
            ThêmNhânViên_Role.Items.Add("Chọn vai trò");
            ThêmNhânViên_Role.Items.Add("Admin");
            ThêmNhânViên_Role.Items.Add("Kế Toán");
            ThêmNhânViên_Role.Items.Add("Quản Lý Kho");
            ThêmNhânViên_Role.SelectedItem = "Chọn vai trò";

            //Gender
            ThêmNhânViên_Gender.Items.Add("Chọn giới tính");
            ThêmNhânViên_Gender.Items.Add("Nam");
            ThêmNhânViên_Gender.Items.Add("Nữ");
            ThêmNhânViên_Gender.SelectedItem = "Chọn giới tính";

            cnn = new SqlConnection(CNT);
            cnn.Open(); 
        }

        private void ThêmNhânViên_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if ((string)ThêmNhânViên_Role.SelectedItem == "Kế Toán")
            {
                Role = 20;
            }
            else if ((string)ThêmNhânViên_Role.SelectedItem == "Admin")
            {
                Role = 50;
            }
            else if ((string)ThêmNhânViên_Role.SelectedItem == "Quản Lý Kho")
            {
                Role = 30;
            }
            else
            {
                Role = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn Có Muốn Lưu Thông Tin Nhân Viên Mới ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                
                if(Role == 0 && Gender == 3)
                {
                    MessageBox.Show("Vui lòng chọn vai trò và giới tính cho nhân viên !");

                }
                else if (Gender == 3)
                {
                    MessageBox.Show("Vui lòng chọn giới tính cho nhân viên !");
                }

                else if (Role == 0)
                {
                    MessageBox.Show("Vui lòng chọn vai trò cho nhân viên !");
                }
                else
                {
                    //Boolean isUNIQUE = true;

                    

                    //kiểm tra tài khoản
                    String cmdStringCHECK2 = "Select * from [User] where UserName = '" + ThêmNhânViên_UserName.Text+"'";
                    SqlCommand cmdCHECK2 = new SqlCommand(cmdStringCHECK2, cnn);
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter CHEKCUNIQUE2 = new SqlDataAdapter(cmdCHECK2);
                    //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
                    CHEKCUNIQUE2.Fill(dt2);

                    if ( dt2.Rows.Count == 0)
                    {
                        String dateTime = ThêmNhânViên_Birth.Value.ToString();

                        String cmdString = "Insert into [user] (FullName,[UserName],Password,Email,Phone,Gender,Role,status, birthday) " +
                        "Values(N'" + ThêmNhânViên_Name.Text + "','" + ThêmNhânViên_UserName.Text + "','" + getPassword() + "','" + ThêmNhânViên_Email.Text + "','" + ThêmNhânViên_Phone.Text + "'," + Gender + "," + Role + ",1,'" + dateTime + "')";
                        SqlCommand cmd = new SqlCommand(cmdString, cnn);

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                        sqlDataAdapter.InsertCommand = new SqlCommand(cmdString, cnn);
                        sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Sussesful !");

                        cmd.Dispose();
                        cmd.Clone();

                        ClearAll();
                    }
                   
                    else if(dt2.Rows.Count != 0)
                    {
                        MessageBox.Show("Tài Khoản Đã Tồn Tại !");
                    }

           

                }
                
            }

            

        }

        private void ClearAll()
        {
            ThêmNhânViên_Role.Text = "";
            ThêmNhânViên_Name.Text = "";
            ThêmNhânViên_Phone.Text = "";
            ThêmNhânViên_UserName.Text = "";
            ThêmNhânViên_Birth.ResetText();
            ThêmNhânViên_Email.Text = "";
            //ThêmNhânViên_password.Text = "";
            ThêmNhânViên_Gender.SelectedItem = "Chọn giới tính";
            ThêmNhânViên_Role.SelectedItem = "Chọn vai trò";
            Role = 0;
            Gender = 3;
        }

        public static int getPassword()
        {
            Random TenBienRanDom = new Random();
            int store = TenBienRanDom.Next(111111, 999999);
            return store;
        }

        private void ThêmNhânViên_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if ((string)ThêmNhânViên_Gender.SelectedItem == "Nam")
            {
                Gender = 0;
            }
            else if ((string)ThêmNhânViên_Gender.SelectedItem == "Nữ")
            {
                Gender= 1;
            }
            else
            {
                Gender = 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Close();
        }
    }
}
