using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            OrgStr = this.lblStatus.Text;   // 예: "상태 : "
            this.pbStatus.Maximum = 100;
            this.pbStatus.Value = 0;
            this.lblStatus.Text = OrgStr + "0%";
        }

        int Num = 0;        
        string OrgStr = ""; 

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 완료 상태면 그대로 두고, 아니면 타이머 재시작
            if (Num < 100)
                this.Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Num < 100)
            {
                Num++;
                this.pbStatus.Value = Num;
                this.lblStatus.Text = OrgStr + Num.ToString() + "%";

                if (Num >= 100)
                {
                    this.Timer.Stop();
                   
                    this.lblStatus.Text = "상태 : 완료";
                }
            }
            else
            {
                this.Timer.Stop();
            }
        }

        private void bntStop_Click(object sender, EventArgs e)
        {
            this.Timer.Stop();
            this.lblStatus.Text = OrgStr + Num.ToString() + "% (중지)";
        }

        private void bntRestart_Click(object sender, EventArgs e)
        {
            this.Timer.Stop();
            Num = 0;
            this.pbStatus.Value = Num;
            this.lblStatus.Text = OrgStr + "0%";
            this.Timer.Start();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
