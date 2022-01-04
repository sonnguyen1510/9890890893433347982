using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_project.Edit;

namespace Final_project.Show
{
    public partial class Thông_Tin_Mặt_Hàng : Form
    {
        public int ID;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Thông_Tin_Mặt_Hàng()
        {
            InitializeComponent();
        }

        public Thông_Tin_Mặt_Hàng(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void ThôngTinMặtHàng_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringProduct = "Select * from Product";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);
            DataTable dtProduct = new DataTable();
            SqlDataAdapter Product_DA = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Product_DA.Fill(dtProduct);

            DataRow[] dr = dtProduct.Select("ProductID = "+ID);

            foreach (DataRow row in dr)
            {
                ThôngTinMH_ID.Text = row["productID"].ToString();
                ThôngTinMH_Name.Text = row["productName"].ToString();
                ThôngTinMH_info.Text = row["productInfo"].ToString();
                ThôngTinMH_Amout.Text = row["amount"].ToString();
                ThôngTinMH_img.Image = CovertByteToImage((byte[])row["Image"]);
                ThôngTinMH_price.Text = row["Productprice"].ToString();
                ThôngTinMH_Date.Text = row["Date"].ToString();

            }
        }


        private static Image CovertByteToImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chỉnh_Sủa_Món_Ăn editProduct = new Chỉnh_Sủa_Món_Ăn(ID, this);
            editProduct.ShowDialog();

        }
    }

}
