﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zodiac
{
    public partial class zodiac : Form
    {
        public zodiac()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void tb_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.Text = "띠 알아내기";
            int year = int.Parse(tb_year.Text);
            String imageFile = "C:\\Users\\kisim\\Desktop\\c#\\Study_A\\7th\\images\\images";

            //쥐 4
            switch (year%12)
            {
                case 0: imageFile += "\\원숭이.png"; break;
                case 1: imageFile += "\\닭.png"; break;
                case 2: imageFile += "\\개.png"; break;
                case 3: imageFile += "\\돼지.png"; break;
                case 4: imageFile += "\\쥐.png"; break;
                case 5: imageFile += "\\소.png"; break;
                case 6: imageFile += "\\호랑이.png"; break;
                case 7: imageFile += "\\토끼.png"; break;
                case 8: imageFile += "\\용.png"; break;
                case 9: imageFile += "\\뱀.png"; break;
                case 10: imageFile += "\\말.png"; break;
                case 11: imageFile += "\\양.png"; break;
              


            }
            pbox.Image = Image.FromFile(imageFile);
            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
