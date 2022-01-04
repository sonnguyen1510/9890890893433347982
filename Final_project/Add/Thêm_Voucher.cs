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

namespace Final_project
{
    public partial class Thêm_Voucher : Form
    {
        public Main main;
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Thêm_Voucher()
        {
            InitializeComponent();
        }

        public Thêm_Voucher(Main main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        private void Thêm_Voucher_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thêm voucher ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(dia == DialogResult.OK)
            {
                String cmdString = "Insert into Voucher (VoucherID ,VoucherName , VoucherPrice ,status) " +
                "values(" + ThêmVoucher_MãVoucher_input.Text + ",'" + ThêmVoucher_TênVoucher_input.Text + "'," + ThêmVoucher_GiáTrịVoucher_input.Text + ",1)";
                SqlCommand cmd = new SqlCommand(cmdString, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = new SqlCommand(cmdString, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();
            }
            else
            {
                MessageBox.Show("Rảnh ghê");
            }
        }
    }
}
