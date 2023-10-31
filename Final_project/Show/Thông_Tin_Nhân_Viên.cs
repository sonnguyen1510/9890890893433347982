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
using Bán_hàng_online_winform.Edit;

namespace Bán_hàng_online_winform
{
    public partial class Thông_Tin_Nhân_Viên : Form
    {
        private string UserName;
        private Form form;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Thông_Tin_Nhân_Viên()
        {
            InitializeComponent();
        }

        public Thông_Tin_Nhân_Viên(string UserName,Form form)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.form = form;
        }

        public void Thông_Tin_Nhân_Viên_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringUser = "Select * from [User]";
            SqlCommand cmdUser = new SqlCommand(cmdStringUser, cnn);
            DataTable dtUser = new DataTable();
            SqlDataAdapter User_DA = new SqlDataAdapter(cmdUser);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            User_DA.Fill(dtUser);

            DataRow[] dr = dtUser.Select("[UserName] = '" + UserName+"'");

            foreach (DataRow row in dr)
            {
                ThôngTinNV_ID.Text = row["UserID"].ToString();
                ThôngTinNV_Name.Text = row["FullName"].ToString();
                ThôngTinNV_UserName.Text = row["UserName"].ToString();
                ThôngTinNV_Phone.Text = row["Phone"].ToString();
                //ThôngTinMH_img.Image = CovertByteToImage((byte[])row["Image"]);
                
                DateTime date = (DateTime)row["Birthday"];

                ThôngTinNV_Birth.Text = date.ToString("dd/MM/yyyy");
                ThôngTinNV_email.Text = row["Email"].ToString();

                if ((Boolean)row["Gender"])
                {
                    ThôngTinNV_Gender.Text = "Nam" ;
                }
                else
                {
                 ThôngTinNV_Gender.Text = "Nữ";
                }


                if(int.Parse(row["Role"].ToString()) == 50)
                {
                    ThôngTinNV_Role.Text = "Admin";
                }
                else if (int.Parse(row["Role"].ToString()) == 30 || int.Parse(row["Role"].ToString()) == 20)
                {
                    ThôngTinNV_Role.Text = "Kế Toán";
                }
                else
                {
                    ThôngTinNV_Role.Text = "Khách Hàng";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chỉnh_Sửa_Thông_Tin_Nhân_Viên Edit = new Chỉnh_Sửa_Thông_Tin_Nhân_Viên(UserName, form);
            Edit.ShowDialog();
        }
    }
}
