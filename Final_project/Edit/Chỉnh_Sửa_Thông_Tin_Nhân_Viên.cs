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

namespace Final_project.Edit
{
    public partial class Chỉnh_Sửa_Thông_Tin_Nhân_Viên : Form
    {
        private string UserName;
        public int Role = 0;
        private int Gender = 3;
        private Form form;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Chỉnh_Sửa_Thông_Tin_Nhân_Viên()
        {
            InitializeComponent();
        }

        public Chỉnh_Sửa_Thông_Tin_Nhân_Viên(String UserName , Form Return)
        {
            InitializeComponent();
            this.UserName = UserName;  
            this.form = Return;
        }

        private void Chỉnh_Sửa_Thông_Tin_Nhân_Viên_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();


            //Role
            SửaThôngTinNV_Role.Items.Add("Chọn vai trò");
            SửaThôngTinNV_Role.Items.Add("Admin");
            SửaThôngTinNV_Role.Items.Add("Kế Toán");
            SửaThôngTinNV_Role.Items.Add("Quản Lý Kho");
            SửaThôngTinNV_Role.SelectedItem = "Chọn vai trò";

            //Gender
            SửaThôngTinNV_Gender.Items.Add("Chọn giới tính");
            SửaThôngTinNV_Gender.Items.Add("Nam");
            SửaThôngTinNV_Gender.Items.Add("Nữ");
            SửaThôngTinNV_Gender.SelectedItem = "Chọn giới tính";

            cnn = new SqlConnection(CNT);
            cnn.Open();



            String cmdStringUser = "Select * from [User]";
            SqlCommand cmdUser = new SqlCommand(cmdStringUser, cnn);
            DataTable dtUser = new DataTable();
            SqlDataAdapter User_DA = new SqlDataAdapter(cmdUser);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            User_DA.Fill(dtUser);

            DataRow[] dr = dtUser.Select("[UserName] = '" + UserName + "'");

            foreach (DataRow row in dr)
            {
                SửaThôngTinNV_ID.Text = row["UserID"].ToString();
                SửaThôngTinNV_Name.Text = row["FullName"].ToString();
                SửaThôngTinNV_UserName.Text = row["UserName"].ToString();
                SửaThôngTinNV_Phone.Text = row["Phone"].ToString();
                //ThôngTinMH_img.Image = CovertByteToImage((byte[])row["Image"]);

                DateTime date = (DateTime)row["Birthday"];

                SửaThôngTinNV_Birth.Value = (DateTime)row["Birthday"];
                SửaThôngTinNV_Email.Text = row["Email"].ToString();

                if ((Boolean)row["Gender"])
                {
                    SửaThôngTinNV_Gender.SelectedItem = "Nam";
                    Gender = 0;
                }
                else
                {
                    SửaThôngTinNV_Gender.SelectedItem = "Nữ";
                    Gender = 1;
                }


                if (int.Parse(row["Role"].ToString()) == 50)
                {
                    SửaThôngTinNV_Role.SelectedItem = "Admin";
                    Role = 50;
                }
                else if (int.Parse(row["Role"].ToString()) == 30 || int.Parse(row["Role"].ToString()) == 20)
                {
                    SửaThôngTinNV_Role.SelectedItem = "Kế Toán";
                    Role = 30;
                }
                else
                {
                    SửaThôngTinNV_Role.SelectedItem = "Khách Hàng";
                    Role = int.Parse(row["Role"].ToString());
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SửaThôngTinNV_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)SửaThôngTinNV_Role.SelectedItem == "Kế Toán")
            {
                Role = 20;
            }
            else if ((string)SửaThôngTinNV_Role.SelectedItem == "Admin")
            {
                Role = 50;
            }
            else if ((string)SửaThôngTinNV_Role.SelectedItem == "Quản Lý Kho")
            {
                Role = 30;
            }
            else
            {
                Role = 0;
            }
        }

        private void SửaThôngTinNV_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)SửaThôngTinNV_Gender.SelectedItem == "Nam")
            {
                Gender = 0;
            }
            else if ((string)SửaThôngTinNV_Gender.SelectedItem == "Nữ")
            {
                Gender = 1;
            }
            else
            {
                Gender = 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn Có Muốn Lưu Thông Tin Nhân Viên Mới ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {

                if (Role == 0 && Gender == 3)
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

                    
                        String dateTime = SửaThôngTinNV_Birth.Value.ToString();

                        String cmdString = "Update [User] set FullName = N'"+ SửaThôngTinNV_Name.Text + "',Email = N'" + SửaThôngTinNV_Email.Text + "',Phone = '" + SửaThôngTinNV_Phone.Text + "',Gender = " + Gender + ",Role =" + Role + ",Status = "+1+",birthday ='" + dateTime + "' where UserName = '"+UserName+"'";
                        SqlCommand cmd = new SqlCommand(cmdString, cnn);
                        cmd.ExecuteNonQuery();
                           
                        MessageBox.Show("Sussesful !");

                        cmd.Dispose();
                        cmd.Clone();

                        
                        this.Close();
                        

                        //ClearAll();
                    



                }

            }
        }
    }
}
