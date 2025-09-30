using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private double o = 0.0; // 폼 Opacity 값 설정 (0 ~ 100 가정)

        // 다른 클래스에서 접근하여 Form의 Text를 바꾸기 위한 set 접근자
        public string SetText
        {
            set { this.Text = value; }  // Form1에서 f.SetText = "..." 형태로 전달
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 처음엔 완전 투명
            this.Opacity = 0.0;
            // 디자이너에서 만든 Timer 컨트롤을 활성화 (Interval은 디자이너에서 10ms로 설정)
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (o < 100.0)
            {
                o += 5.0;                 // 5%씩 증가 (속도는 필요에 따라 조절)
                this.Opacity = o / 100.0; // 0.0 ~ 1.0 사이로 변환
            }
            else
            {
                this.Timer.Enabled = false; // 다 나타나면 타이머 종료
            }
        }
    }
}