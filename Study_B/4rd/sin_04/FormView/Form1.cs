using System;
using System.Windows.Forms;

namespace FormView
{
    public partial class Form1 : Form   // 반드시 Form을 상속해야 함
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 필요시 초기화 코드
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new Form2())
            {
                f.ShowDialog(this);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.Show(this);
        }
    }
}
