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

namespace Final_project.Show
{
    public partial class Thông_Tin_Hóa_Đơn : Form
    {
        private int OrderID;
        private Form Return;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;

        public Thông_Tin_Hóa_Đơn()
        {
            InitializeComponent();
        }

        public Thông_Tin_Hóa_Đơn(Form Return , int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            this.Return = Return;
        }

        private void ThêmMónĂn_Mãmónăn_Click(object sender, EventArgs e)
        {
           
        }

        private void Thông_Tin_Hóa_Đơn_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringOrder = "Select OrderID,FullName,phone,Address,Totalprice,OrderDate from [Order] where status = 1";
            SqlCommand cmdOrder = new SqlCommand(cmdStringOrder, cnn);
            DataTable dtOrder = new DataTable();
            SqlDataAdapter Order_DA = new SqlDataAdapter(cmdOrder);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Order_DA.Fill(dtOrder);

            DataRow[] dr = dtOrder.Select("OrderID = " + OrderID);

            foreach (DataRow row in dr)
            {
                ThôngTinHD_ID.Text = row["OrderID"].ToString();
                ThôngTinHD_Name.Text = row["FullName"].ToString();
                ThôngTinHD_Phone.Text = row["Phone"].ToString();
                ThôngTinHD_Address.Text = row["Address"].ToString();
                ThôngTinHD_price.Text = row["Totalprice"].ToString();
                ThôngTinHD_Date.Text = row["OrderDate"].ToString();

            }


            String cmdStringDetail = "Select * from [Cart] where OrderID = " + OrderID;
            SqlCommand cmdDetail = new SqlCommand(cmdStringDetail, cnn);
            DataTable dtDetail = new DataTable();
            DataColumn Detail = new DataColumn("Tick", typeof(Boolean));
            dtDetail.Columns.Add(Detail);

            SqlDataAdapter Detail_DA = new SqlDataAdapter(cmdDetail);
            Detail_DA.Fill(dtDetail);

            ThôngTInHD_Chi_Tiết.AllowUserToAddRows = false;
            //ThôngTInHD_Chi_Tiết.Columns[0].Width = 40;
            ThôngTInHD_Chi_Tiết.DataSource = dtDetail;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)ThôngTInHD_Chi_Tiết.DataSource;

            foreach (DataRow row in temp.Rows)
            {
                Boolean IsCheck = Check(row["Tick"].ToString());
                if (IsCheck)
                {
                    Thông_Tin_Mặt_Hàng show = new Thông_Tin_Mặt_Hàng(int.Parse(row["productID"].ToString()));
                    show.ShowDialog();
                }

            }
        }

        private bool Check(string v)
        {
            if (v == "True")
            {
                return true;
            }
            else
                return false;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
    }
