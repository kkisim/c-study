using System;
using System.Windows.Forms;

namespace sin_06   // ← 프로젝트 네임스페이스에 맞춰 유지/수정
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 디자인 스펙
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // 디자이너에서 클릭 이벤트가 안 걸렸을 경우 대비
            btnMsg.Click -= btnMsg_Click;
            btnMsg.Click += btnMsg_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMsg.Text))
                txtMsg.Text = "트레이 메시지 테스트입니다.";
        }

        // ❶ [보이기] 버튼 클릭 시 Form2 호출
        private void btnMsg_Click(object sender, EventArgs e)
        {
            string msg = string.IsNullOrWhiteSpace(txtMsg.Text)
                ? "내용이 없어 기본 메시지를 표시합니다."
                : txtMsg.Text.Trim();

            // 문서의 ④번(set 접근자) 규칙에 맞게 메시지 전달
            var frm = new Form2();   // Form2는 기본 생성자 보유
            frm.MsgText = msg;       // public string MsgText { set { lblResult.Text = value; } }
            frm.Show();              // 표시(폼 내부 타이머로 자동 닫힘 처리)
        }
    }
}
