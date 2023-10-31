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
using Bán_hàng_online_winform.Show;
using System.Text.RegularExpressions;
using Bán_hàng_online_winform.Dialog;
using Bán_Hàng_Onl_WinForm.Function;

namespace Bán_hàng_online_winform
{
    public partial class Kế_Toán_Form : Form
    {
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;

        public Đăng_Nhập Đăng_Nhập;
        private string UserName;

        public Kế_Toán_Form()
        {
            InitializeComponent();


            //KếToán_MặtHàng_TB.Columns.Add(newCol);

        }

        public Kế_Toán_Form(Đăng_Nhập đăng_Nhập, String UserName)
        {
            InitializeComponent();
            this.Đăng_Nhập = đăng_Nhập;
            this.UserName = UserName;


            //KếToán_MặtHàng_TB.Columns.Add(newCol);

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void KếToán_MặtHàng_TB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void Kế_Toán_Form_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringProduct = "Select ProductID as ID,ProductName as Name,ProductInfo as Information,Productprice as Price,amount as Amount from Product where status = 1";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);


            DataTable dtProduct = new DataTable();
            DataColumn dcProduct = new DataColumn("Tick", typeof(Boolean));
            dtProduct.Columns.Add(dcProduct);

            SqlDataAdapter Product_DA = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Product_DA.Fill(dtProduct);

            KếToán_MặtHàng_TB.AllowUserToAddRows = false;
            KếToán_MặtHàng_TB.DataSource = dtProduct;
            KếToán_MặtHàng_TB.Columns[0].Width = 40;

            //---------------------------------ORDER----------------------------------
            String cmdOrder = "Select * from [Order] where status = 1";
            SqlCommand Order_cmd = new SqlCommand(cmdOrder, cnn);
            DataTable Order_dt = new DataTable();
            DataColumn dcOrder = new DataColumn("Tick", typeof(Boolean));
            Order_dt.Columns.Add(dcOrder);

            SqlDataAdapter Order_DA = new SqlDataAdapter(Order_cmd);
            Order_DA.Fill(Order_dt);

            
            KếToán_HóaĐơn_TB.AllowUserToAddRows = false;
            KếToán_HóaĐơn_TB.DataSource = Order_dt;
            KếToán_HóaĐơn_TB.Columns[0].Width = 40;


        }



        private void button16_Click(object sender, EventArgs e)
        {
            String cmdOrder = "Select * from [Order] where status = 1";
            SqlCommand Order_cmd = new SqlCommand(cmdOrder, cnn);
            DataTable Order_dt = new DataTable();
            DataColumn dcOrder = new DataColumn("Tick", typeof(Boolean));
            Order_dt.Columns.Add(dcOrder);

            SqlDataAdapter Order_DA = new SqlDataAdapter(Order_cmd);
            Order_DA.Fill(Order_dt);


            KếToán_HóaĐơn_TB.AllowUserToAddRows = false;
            KếToán_HóaĐơn_TB.DataSource = Order_dt;
            KếToán_HóaĐơn_TB.Columns[0].Width = 40;

        }

        private void Main_refesh_Click(object sender, EventArgs e)
        {
            String cmdStringProduct = "Select ProductID as ID,ProductName as Name,ProductInfo as Information,Productprice as Price,amount as Amount from Product where status = 1";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);


            DataTable dtProduct = new DataTable();
            DataColumn dcProduct = new DataColumn("Tick", typeof(Boolean));
            dtProduct.Columns.Add(dcProduct);

            SqlDataAdapter Product_DA = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Product_DA.Fill(dtProduct);

            KếToán_MặtHàng_TB.AllowUserToAddRows = false;
            KếToán_MặtHàng_TB.DataSource = dtProduct;
            KếToán_MặtHàng_TB.Columns[0].Width = 40;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)KếToán_MặtHàng_TB.DataSource;

            foreach (DataRow row in temp.Rows)
            {
                Boolean IsCheck = Check(row["Tick"].ToString());
                if (IsCheck)
                {
                    Thông_Tin_Mặt_Hàng show = new Thông_Tin_Mặt_Hàng(int.Parse(row["ID"].ToString()));
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

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đăng_Nhập.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình hay không", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //MessageBox.Show("You have clicked Ok Button");
                this.Close();
                System.Windows.Forms.Application.Exit();
                //Some task…  
            }
            if (res == DialogResult.Cancel)
            {
                // MessageBox.Show("You have clicked Cancel Button");
                //Some task…  
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đổi_Mật_Khẩu đổi_Mật_Khẩu = new Đổi_Mật_Khẩu(UserName, this);
            đổi_Mật_Khẩu.ShowDialog();
            //this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cmdStringProduct = "Select ProductID as ID,ProductName as Name,ProductInfo as Information,Productprice as Price,amount as Amount from Product where status = 1";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);


            DataTable dtProduct = new DataTable();
            DataColumn dcProduct = new DataColumn("Tick", typeof(Boolean));
            dtProduct.Columns.Add(dcProduct);

            SqlDataAdapter Product_DA = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Product_DA.Fill(dtProduct);
            KếToán_MặtHàng_TB.AllowUserToAddRows = false;
            KếToán_MặtHàng_TB.DataSource = dtProduct;
            KếToán_MặtHàng_TB.Columns[0].Width = 40;

            PdfExporter.ExportDataTableToPdf(dtProduct);
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            String cmdOrder = "Select * from [Order] where status = 1";
            SqlCommand Order_cmd = new SqlCommand(cmdOrder, cnn);
            DataTable Order_dt = new DataTable();
            DataColumn dcOrder = new DataColumn("Tick", typeof(Boolean));
            Order_dt.Columns.Add(dcOrder);

            SqlDataAdapter Order_DA = new SqlDataAdapter(Order_cmd);
            Order_DA.Fill(Order_dt);
            
            KếToán_HóaĐơn_TB.AllowUserToAddRows = false;
            KếToán_HóaĐơn_TB.DataSource = Order_dt;

            //XP(KếToán_HóaĐơn_TB);
            DataTable export = new DataTable();
            export = Order_dt.Copy();
            export.Columns.Remove("Tick");

            PdfExporter.ExportDataTableToPdf(export);
        }

        public static void RemoveColumn(DataTable dataTable, string columnName)
        {
            if (dataTable.Columns.Contains(columnName))
            {
                dataTable.Columns.Remove(columnName);
            }
        }

        private void MặtHàng_StartDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)KếToán_HóaĐơn_TB.DataSource;

            foreach (DataRow row in temp.Rows)
            {
                Boolean IsCheck = Check(row["Tick"].ToString());
                if (IsCheck)
                {
                    Thông_Tin_Hóa_Đơn show = new Thông_Tin_Hóa_Đơn(this, int.Parse(row["OrderID"].ToString()));
                    show.ShowDialog();
                }

            }
        }

        private void thêmMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thêm_món_ăn add = new Thêm_món_ăn(this);
            add.ShowDialog();
        }
    }
}
