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

namespace Final_project.Edit
{
    public partial class Chỉnh_Sủa_Món_Ăn : Form
    {
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Image LoadImg = null;
        private Form Return;
        private int ProductID;
        public Chỉnh_Sủa_Món_Ăn(int ProductID, Form Return)
        {
            InitializeComponent();
            this.ProductID = ProductID;
            this.Return = Return;

        }

        private void Chỉnh_Sủa_Món_Ăn_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();

            String cmdStringProduct = "Select * from Product";
            SqlCommand cmdProduct = new SqlCommand(cmdStringProduct, cnn);
            DataTable dtProduct = new DataTable();
            SqlDataAdapter Product_DA = new SqlDataAdapter(cmdProduct);
            //SqlDataAdapter Login_Check_by_email = new SqlDataAdapter(cmd2);
            Product_DA.Fill(dtProduct);

            DataRow[] dr = dtProduct.Select("ProductID = " + ProductID);

            foreach (DataRow row in dr)
            {
                SửaMónĂn_Mãmónăn_input.Text = row["productID"].ToString();
                SửaMónĂn_TênMónĂn_input.Text = row["productName"].ToString();
                SửaMónĂn_ChiTiếtMónĂn_input.Text = row["productInfo"].ToString();
                SửaMónĂn_SốLượngMónĂn_input.Text = row["amount"].ToString();
                SửaMónĂn_ShowImg.Image = CovertByteToImage((byte[])row["Image"]);
                LoadImg = CovertByteToImage((byte[])row["Image"]);
                SửaMónĂn_GiáMónĂn_input.Text = row["Productprice"].ToString();
                //ThôngTinMH_Date.Text = row["Date"].ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (* .Jpeg, * .jpg , *.png) | * .Jpeg; *. Jpg ; *.png",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LoadImg = Image.FromFile(ofd.FileName);
                    //ThêmMónĂn_ShowImg.Image = LoadImg;
                    CHọn_Hình_Ảnh_Món_Ăn testPG = new CHọn_Hình_Ảnh_Món_Ăn(CovertByteToImage(ConvertImageToByte(LoadImg)), this);
                    testPG.ShowDialog();

                }
            }
        }

        public void ShowIMG()
        {
            SửaMónĂn_ShowImg.Image = LoadImg;
        }


        private static Byte[] ConvertImageToByte(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
                return new Byte[0];

            //return image;
        }

        private static Image CovertByteToImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private void ThêmMónĂn_Save_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn lưu thông tin hay không ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                //Byte[] img = null;//new Byte[ConvertImageToByte(LoadImg).Length+1](ConvertImageToByte(LoadImg));

                DateTime now = DateTime.Now;

                String cmdString = "Update Product set"+
                    "   ProductName = N'" + SửaMónĂn_TênMónĂn_input.Text + "'" +
                    " , ProductInfo = N'" + SửaMónĂn_ChiTiếtMónĂn_input.Text + "'" +
                    " , ProductPrice = " + SửaMónĂn_GiáMónĂn_input.Text + "" +
                    " , Amount = " + SửaMónĂn_SốLượngMónĂn_input.Text + " " +
                    " , Status = " + 1 + "" +
                    " , [Image] = @Image" +
                    " where ProductID = "+ ProductID;

                //MessageBox.Show(ConvertImageToByte(LoadImg).ToString());
                SqlCommand cmd = new SqlCommand(cmdString, cnn);
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = ConvertImageToByte(LoadImg);

                //SqlDataAdapter adt = new SqlDataAdapter(cmd);
                //adt.InsertCommand.;
                cmd.ExecuteNonQuery();
                //adt.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Clone();

                MessageBox.Show("Sucessfull");
                this.Close();
            }
            if (dia == DialogResult.Cancel)
            {

            }
        }

        private void ThêmMónĂn_Cancel_Click(object sender, EventArgs e)
        {
            Return.Show();
            this.Close();   
        }
    }
}
