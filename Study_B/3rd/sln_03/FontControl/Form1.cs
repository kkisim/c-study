using System;
using System.Windows.Forms;
namespace FontControl
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }
        private void tsbtnFont_Click(object sender, EventArgs e)
        { if (this.fontDlg.ShowDialog() == DialogResult.OK) { this.rtbText.SelectionFont = this.fontDlg.Font; } }
        private void tsbtnColor_Click(object sender, EventArgs e)
        { if (this.colorDlg.ShowDialog() == DialogResult.OK) { this.rtbText.SelectionColor = this.colorDlg.Color; } }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}