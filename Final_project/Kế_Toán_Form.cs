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
using Final_project.Show;
using System.Text.RegularExpressions;
using Final_project.Dialog;

namespace Final_project
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

        private void Kế_Toán_Form_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringProduct = "Select ProductID as Mã_sản_phẩm,ProductName as Tên_sản_phẩm,ProductInfo as Thông_tin_sản_phẩm,Productprice as Giá_sản_phẩm,amount as Số_lượng_sản_phẩm,[Image] as Hình_ảnh from Product where status = 1";
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
            String cmdStringProduct = "Select ProductID as Mã_sản_phẩm,ProductName as Tên_sản_phẩm,ProductInfo as Thông_tin_sản_phẩm,Productprice as Giá_sản_phẩm,amount as Số_lượng_sản_phẩm from Product where status = 1";
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
                    Thông_Tin_Mặt_Hàng show = new Thông_Tin_Mặt_Hàng(int.Parse(row["Mã_sản_phẩm"].ToString()));
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
            String cmdStringProduct = "Select ProductID as Mã_sản_phẩm,ProductName as Tên_sản_phẩm,ProductInfo as Thông_tin_sản_phẩm,Productprice as Giá_sản_phẩm,amount as Số_lượng_sản_phẩm from Product where  [Date] BETWEEN '"+MặtHàng_StartDay.Value+"' AND '"+MặtHàng_Endday.Value+"' AND status = 1";
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

            XP(KếToán_MặtHàng_TB);
        }

        public void XP(DataGridView GV)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Execl file (*.xlsx)|*.xlsx | Excel 2007 (*.xls) | *.xls ";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Title = "Xuất file thống kê";
            //saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 15;

                for (int i = 1; i < GV.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = GV.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < GV.Rows.Count; i++)
                {
                    for (int j = 0; j < GV.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = GV.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
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

            XP(KếToán_HóaĐơn_TB);
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
