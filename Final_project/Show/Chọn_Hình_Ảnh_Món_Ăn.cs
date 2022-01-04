using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_project.Show;
using Final_project.Edit;

namespace Final_project
{
    public partial class CHọn_Hình_Ảnh_Món_Ăn : Form
    {
        public Image img;
        //private Image LoadImg;
        private Thêm_món_ăn thêm_Món_Ăn;
        private int No;
        private Chỉnh_Sủa_Món_Ăn chỉnh_Sủa_Món_Ăn;

        public CHọn_Hình_Ảnh_Món_Ăn()
        {
            InitializeComponent();
        }

        public CHọn_Hình_Ảnh_Món_Ăn(Image img, Thêm_món_ăn thêm_Món_Ăn)
        {
            this.img = img;
            InitializeComponent();
            this.thêm_Món_Ăn = thêm_Món_Ăn;
            this.No = 1;
        }

        public CHọn_Hình_Ảnh_Món_Ăn(Image img, Chỉnh_Sủa_Món_Ăn chỉnh_Sủa_Món_Ăn)
        {
            this.img = img;
            InitializeComponent();
            this.chỉnh_Sủa_Món_Ăn = chỉnh_Sủa_Món_Ăn;
            this.No = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TestPG_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (* .Jpeg, * .jpg , *.png) | * .Jpeg; *. Jpg ; *.png",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img = Image.FromFile(ofd.FileName);
                    pictureBox1.Image = img;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(No == 1)
            {
                thêm_Món_Ăn.LoadImg = img;
                thêm_Món_Ăn.ShowIMG();
                this.Close();
            }
            else if(No == 2)
            {
                chỉnh_Sủa_Món_Ăn.LoadImg = img;
                chỉnh_Sủa_Món_Ăn.ShowIMG();
                this.Close();   
            }
        }
    }
}
