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

namespace Final_project
{
    public partial class Thêm_món_ăn : Form
    {
        public string CNT = ConfigurationManager.ConnectionStrings["Final_project_database"].ConnectionString;
        public SqlConnection cnn;
        public Image LoadImg = null;
        private Form Main;

        public Thêm_món_ăn()
        {
            InitializeComponent();
        }

        public Thêm_món_ăn(Form main)
        {
            InitializeComponent();
            this.Main = main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.Show();
            this.Close();
            cnn.Close();
        }

        private void Thêm_món_ăn_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(CNT);
            cnn.Open();
        }

        private void ThêmMónĂn_Save_Click(object sender, EventArgs e)
        {
            if (LoadImg != null)
            {
                DialogResult dia = MessageBox.Show("Bạn có chắc muốn lưu thông tin hay không ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dia == DialogResult.OK)
                {
                    //Byte[] img = null;//new Byte[ConvertImageToByte(LoadImg).Length+1](ConvertImageToByte(LoadImg));

                    DateTime now = DateTime.Now;

                    String cmdString = "Insert into Product(ProductName,ProductInfo,Productprice,amount,status,[image],[Date]) " +
                        "values(N'" + ThêmMónĂn_TênMónĂn_input.Text + "',N'" + ThêmMónĂn_ChiTiếtMónĂn_input.Text + "'," + ThêmMónĂn_GiáMónĂn_input.Text + "," + ThêmMónĂn_SốLượngMónĂn_input.Text + "," + 1 + ",@Image,GETDATE())";

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
                    ThêmMónĂn_TênMónĂn_input.Text = "";
                    ThêmMónĂn_SốLượngMónĂn_input.Text = "";
                    
                    ThêmMónĂn_GiáMónĂn_input.Text = "";
                    ThêmMónĂn_ChiTiếtMónĂn_input.Text = "";
                    
                    LoadImg = null;
                    ThêmMónĂn_ShowImg.Image = null;
                }
                if (dia == DialogResult.Cancel)
                {

                }
            }
            else
                MessageBox.Show("Vui lòng thêm hình ảnh minh họa món ăn !");
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (* .Jpeg, * .jpg , *.png) | * .Jpeg; *. Jpg ; *.png",
                Multiselect = false
            })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                     LoadImg = Image.FromFile(ofd.FileName);
                     //ThêmMónĂn_ShowImg.Image = LoadImg;
                     CHọn_Hình_Ảnh_Món_Ăn testPG =new CHọn_Hình_Ảnh_Món_Ăn(CovertByteToImage(ConvertImageToByte(LoadImg)), this);
                     testPG.ShowDialog();
                    
                }
            }
        }

        public void ShowIMG()
        {
            ThêmMónĂn_ShowImg.Image = LoadImg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2_Click(sender, e);
        }

        private static Byte[] ConvertImageToByte( Image image)
        {
            if(image != null)
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
       
    }
}
