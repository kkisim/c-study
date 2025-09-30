using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_image
{
    public partial class Form1 : Form
    {
        int ImgCount = 0;       // 전체 이미지 개수
        int currentIndex = 0;   // 현재 보여주는 이미지 인덱스

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImgCount = this.ImgList?.Images?.Count ?? 0;

            if (ImgCount == 0)
            {
                picImg.Image = null;
                btnNext.Enabled = false;
              
               
                return;
            }

            currentIndex = 0;
            picImg.SizeMode = PictureBoxSizeMode.Zoom;
            picImg.Image = this.ImgList.Images[currentIndex];
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= ImgCount) currentIndex = 0;
            this.picImg.Image = this.ImgList.Images[currentIndex];
        }

 
        private void picImg_Click(object sender, EventArgs e)
        {
            // 필요하면 클릭했을 때 동작 작성
            // 예: MessageBox.Show("이미지 클릭됨");
        }

    }

}
