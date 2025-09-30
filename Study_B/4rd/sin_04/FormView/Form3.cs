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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // 다른 클래스에서 접근하여 Form의 Text를 바꾸기 위한 set 접근자
        public string SetText
        {
            set { this.Text = value; }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 모달리스는 투명도 100%로 시작
            this.Opacity = 1.0;
            // PDF에서 크기 0,0으로 시작해 점점 키우는 예제 — 디자이너에서 Size를 0,0으로 주었다면 그대로 사용
            // 여기서는 타이머만 활성화
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 목표 크기(예: 300x300)보다 커지면 타이머 종료
            if (this.Size.Width > 300 && this.Size.Height > 300)
            {
                this.Timer.Enabled = false;
            }
            else
            {
                // 매 틱마다 크기를 조금씩 증가
                int w = this.Size.Width + 10;
                int h = this.Size.Height + 10;
                this.Size = new Size(w, h);
            }
        }
    }
}
