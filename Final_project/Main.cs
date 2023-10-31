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
using Bán_hàng_online_winform.Dialog;
using Bán_hàng_online_winform.Show;

namespace Bán_hàng_online_winform
{
    public partial class Main : Form
    {
        public string userName;
        public string Password;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        private Đăng_Nhập Đăng_Nhập;

        public string UserName;

        public Main()
        {
            InitializeComponent();
        }

        public Main(string UserName, string Password)
        {
            this.userName = UserName;
            this.Password = Password;
            InitializeComponent();
        }



        public Main(Đăng_Nhập đăng_Nhập, String UserName)
        {

            this.Đăng_Nhập = đăng_Nhập;
            this.UserName = UserName;
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();
            //Sản Phẩm

            String cmdStringProduct = "Select ProductID as Mã_sản_phẩm,ProductName as Tên_sản_phẩm,ProductInfo as Thông_tin_sản_phẩm,Productprice as Giá_sản_phẩm,amount as Số_lượng_sản_phẩm,Image as Hình_Ảnh_Món_Ăn from Product where status = 1";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);
            DataTable dtProduct = new DataTable();
            DataColumn dcProduct = new DataColumn("Tick", typeof(Boolean));
            dtProduct.Columns.Add(dcProduct);
            SqlDataAdapter Login_check = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Login_check.Fill(dtProduct);
            Main_ThôngTinMặtHàng.AllowUserToAddRows = false;
            Main_ThôngTinMặtHàng.DataSource = dtProduct;
            Main_ThôngTinMặtHàng.Columns[0].Width = 40;


            //Voucher

            String cmdStringVoucher = "Select VoucherID as Mã_Voucher, VoucherName as Tên_Voucher , VoucherPrice as Giá_Trị_Voucher from Voucher where status = 1";
            SqlCommand cmdVoucher = new SqlCommand(cmdStringVoucher, cnn);
            DataTable VoucherDT = new DataTable();
            DataColumn dcVoucher = new DataColumn("Tick", typeof(Boolean));
            VoucherDT.Columns.Add(dcVoucher);
            SqlDataAdapter VoucherDA = new SqlDataAdapter(cmdVoucher);
            VoucherDA.Fill(VoucherDT);
            Main_ThôngTinVoucher.AllowUserToAddRows = false;
            Main_ThôngTinVoucher.DataSource = VoucherDT;
            Main_ThôngTinVoucher.Columns[0].Width = 40;

            //Nhân Viên

            String cmdStringNhânViên = "Select * from [User] where Role = 50 or Role = 30 or Role = 20 and status = 1";
            SqlCommand Nhân_Viên_cmd = new SqlCommand(cmdStringNhânViên, cnn);
            DataTable Nhân_viên_dt = new DataTable();
            DataColumn dcNhân_viên = new DataColumn("Tick", typeof(Boolean));
            Nhân_viên_dt.Columns.Add(dcNhân_viên);

            SqlDataAdapter Nhân_Viên_DA = new SqlDataAdapter(Nhân_Viên_cmd);
            Nhân_Viên_DA.Fill(Nhân_viên_dt);
            Main_ThôngTinNhânViên.AllowUserToAddRows = false;
            Main_ThôngTinNhânViên.DataSource = Nhân_viên_dt;
            Main_ThôngTinNhânViên.Columns[0].Width = 40;

            //Khách Hàng

            String cmdStringKH = "Select * from [User] where [Role] is null and status = 1";
            SqlCommand KH_cmd = new SqlCommand(cmdStringKH, cnn);
            DataTable KH_dt = new DataTable();
            DataColumn dcKH = new DataColumn("Tick", typeof(Boolean));
            KH_dt.Columns.Add(dcKH);

            SqlDataAdapter KH_DA = new SqlDataAdapter(KH_cmd);
            KH_DA.Fill(KH_dt);
            Main_ThôngTinNgDùng.AllowUserToAddRows = false;
            Main_ThôngTinNgDùng.DataSource = KH_dt;
            Main_ThôngTinNgDùng.Columns[0].Width = 40;

            //Order
            String cmdOrder = "Select * from [Order] where status = 1";
            SqlCommand Order_cmd = new SqlCommand(cmdOrder, cnn);
            DataTable Order_dt = new DataTable();
            DataColumn dcOrder = new DataColumn("Tick", typeof(Boolean));
            Order_dt.Columns.Add(dcOrder);

            SqlDataAdapter Order_DA = new SqlDataAdapter(Order_cmd);
            Order_DA.Fill(Order_dt);
            Main_ThôngTinHóaĐơn.AllowUserToAddRows = false;
            Main_ThôngTinHóaĐơn.DataSource = Order_dt;
            Main_ThôngTinHóaĐơn.Columns[0].Width = 40;
        }

        private void thêmMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thêm_món_ăn add = new Thêm_món_ăn(this);
            add.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đăng_Nhập.Show();
            Đăng_Nhập.Đăng_Nhập_Load(sender, e);
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

        private void Main_ThôngTinMặtHàng_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_refesh_Click(object sender, EventArgs e)
        {
            String cmdStringProduct = "Select ProductID as Mã_sản_phẩm,ProductName as Tên_sản_phẩm,ProductInfo as Thông_tin_sản_phẩm,Productprice as Giá_sản_phẩm,amount as Số_lượng_sản_phẩm,Image as Hình_Ảnh_Món_Ăn from Product where status = 1";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);
            DataTable dtProduct = new DataTable();
            DataColumn dcProduct = new DataColumn("Tick", typeof(Boolean));
            dtProduct.Columns.Add(dcProduct);
            SqlDataAdapter Login_check = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Login_check.Fill(dtProduct);
            Main_ThôngTinMặtHàng.AllowUserToAddRows = false;
            Main_ThôngTinMặtHàng.DataSource = dtProduct;
            Main_ThôngTinMặtHàng.Columns[0].Width = 40;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thêmVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thêm_Voucher addVC = new Thêm_Voucher(this);
            addVC.ShowDialog();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thêmMónĂnToolStripMenuItem_Click(sender, e);
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thêm_Nhân_Viên thêm_Nhân_Viên = new Thêm_Nhân_Viên(this);
            //this.Hide();
            thêm_Nhân_Viên.ShowDialog();

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Đổi_Mật_Khẩu quên = new Đổi_Mật_Khẩu(UserName, this);
            //this.Hide();
            quên.ShowDialog();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            String cmdStringVoucher = "Select VoucherID as Mã_Voucher, VoucherName as Tên_Voucher , VoucherPrice as Giá_Trị_Voucher from Voucher where status = 1";
            SqlCommand cmdVoucher = new SqlCommand(cmdStringVoucher, cnn);
            DataTable VoucherDT = new DataTable();
            DataColumn dcVoucher = new DataColumn("Tick", typeof(Boolean));
            VoucherDT.Columns.Add(dcVoucher);
            SqlDataAdapter VoucherDA = new SqlDataAdapter(cmdVoucher);
            VoucherDA.Fill(VoucherDT);
            Main_ThôngTinVoucher.AllowUserToAddRows = false;
            Main_ThôngTinVoucher.DataSource = VoucherDT;
            Main_ThôngTinVoucher.Columns[0].Width = 40;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String cmdStringNhânViên = "Select * from [User] where Role = 50 or Role = 30 or Role = 20 and status = 1";
            SqlCommand Nhân_Viên_cmd = new SqlCommand(cmdStringNhânViên, cnn);
            DataTable Nhân_viên_dt = new DataTable();
            DataColumn dcNhân_viên = new DataColumn("Tick", typeof(Boolean));
            Nhân_viên_dt.Columns.Add(dcNhân_viên);

            SqlDataAdapter Nhân_Viên_DA = new SqlDataAdapter(Nhân_Viên_cmd);
            Nhân_Viên_DA.Fill(Nhân_viên_dt);
            Main_ThôngTinNhânViên.AllowUserToAddRows = false;
            Main_ThôngTinNhânViên.DataSource = Nhân_viên_dt;
            Main_ThôngTinNhânViên.Columns[0].Width = 40;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)Main_ThôngTinMặtHàng.DataSource;

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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thông_Tin_Nhân_Viên info = new Thông_Tin_Nhân_Viên(UserName, this);
            info.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm hay không ?", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                DataTable temp = new DataTable();
                temp = (DataTable)Main_ThôngTinMặtHàng.DataSource;

                foreach (DataRow row in temp.Rows)
                {
                    Boolean IsCheck = Check(row["Tick"].ToString());
                    if (IsCheck)
                    {
                        SqlCommand cmd = new SqlCommand("Update Product set status = 0 where ProductID = " + row["Mã_sản_phẩm"].ToString(), cnn);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                        cmd.Clone();
                        break;

                    }

                }
                Main_refesh_Click(sender, e);
                MessageBox.Show("Sucessful!");
                this.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)Main_ThôngTinNhânViên.DataSource;

            foreach (DataRow row in temp.Rows)
            {
                Boolean IsCheck = Check(row["Tick"].ToString());
                if (IsCheck)
                {
                    Thông_Tin_Nhân_Viên show = new Thông_Tin_Nhân_Viên(row["UserName"].ToString(), this);
                    show.ShowDialog();
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                DataTable temp = new DataTable();
                temp = (DataTable)Main_ThôngTinNhânViên.DataSource;

                foreach (DataRow row in temp.Rows)
                {
                    Boolean IsCheck = Check(row["Tick"].ToString());
                    if (IsCheck)
                    {
                        SqlCommand cmd = new SqlCommand("Update [User] set status = 0  where UserName = '" + row["UserName"].ToString() + "'", cnn);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                        cmd.Clone();
                        break;

                    }

                }
                Main_refesh_Click(sender, e);
                MessageBox.Show("Sucessful!");
                this.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            thêmNhânViênToolStripMenuItem_Click(sender, e);
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
            Main_ThôngTinHóaĐơn.AllowUserToAddRows = false;
            Main_ThôngTinHóaĐơn.DataSource = Order_dt;
            Main_ThôngTinHóaĐơn.Columns[0].Width = 40;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không ?", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                DataTable temp = new DataTable();
                temp = (DataTable)Main_ThôngTinHóaĐơn.DataSource;

                foreach (DataRow row in temp.Rows)
                {
                    Boolean IsCheck = Check(row["Tick"].ToString());
                    if (IsCheck)
                    {
                        SqlCommand cmd = new SqlCommand("update [Order] set status = 0  where [OrderID] = '" + row["OrderID"].ToString() + "'", cnn);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                        cmd.Clone();
                        break;

                    }

                }
                Main_refesh_Click(sender, e);
                MessageBox.Show("Sucessful!");
                this.Show();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa voucher này không ?", "Confrimation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                DataTable temp = new DataTable();
                temp = (DataTable)Main_ThôngTinVoucher.DataSource;

                foreach (DataRow row in temp.Rows)
                {
                    Boolean IsCheck = Check(row["Tick"].ToString());
                    if (IsCheck)
                    {
                        SqlCommand cmd = new SqlCommand("Update [Voucher] set status = 0  where [VoucherID] = '" + row["Mã_Voucher"].ToString() + "'", cnn);
                        cmd.ExecuteNonQuery();

                        cmd.Dispose();
                        cmd.Clone();
                        break;

                    }

                }
                Main_refesh_Click(sender, e);
                MessageBox.Show("Sucessful!");
                this.Show();
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            DataTable temp = new DataTable();
            temp = (DataTable)Main_ThôngTinHóaĐơn.DataSource;

            foreach (DataRow row in temp.Rows)
            {
                Boolean IsCheck = Check(row["Tick"].ToString());
                if (IsCheck)
                {
                    Thông_Tin_Hóa_Đơn show = new Thông_Tin_Hóa_Đơn(this,int.Parse(row["OrderID"].ToString()));
                    show.ShowDialog();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String cmdStringKH = "Select * from [User] where [Role] is null and status = 1";
            SqlCommand KH_cmd = new SqlCommand(cmdStringKH, cnn);
            DataTable KH_dt = new DataTable();
            DataColumn dcKH = new DataColumn("Tick", typeof(Boolean));
            KH_dt.Columns.Add(dcKH);

            SqlDataAdapter KH_DA = new SqlDataAdapter(KH_cmd);
            KH_DA.Fill(KH_dt);
            Main_ThôngTinNgDùng.AllowUserToAddRows = false;
            Main_ThôngTinNgDùng.DataSource = KH_dt;
            Main_ThôngTinNgDùng.Columns[0].Width = 40;
        }
    }
}
