using System;
using System.Windows.Forms;
using System.Timers;   // Timer 사용 (System.Timers.Timer)

namespace sin_06
{
    public partial class Form2 : Form
    {
        // === 설정값 ===
        private const int TargetHeight = 120; // 완전히 펼쳤을 때 높이
        private const int MinHeight = 2;      // 접힌 높이
        private const int Step = 4;           // 프레임 당 높이 변화

        // 타이머 & 델리게이트
        private static System.Timers.Timer TimerEvent;
        private delegate void OnDelegateHeight(int flag); // 0:올리기, 1:내리기, 2:종료
        private OnDelegateHeight OnHeight;

        // Form1에서 메시지를 전달받기 위한 set 전용 프로퍼티
        public string MsgText
        {
            set { lblResult.Text = value; }
        }

        public Form2()
        {
            InitializeComponent();

            // 트레이 팝업 스타일
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            StartPosition = FormStartPosition.Manual;

            // 처음엔 접힌 상태로 시작
            Width = 320;
            Height = MinHeight;
            RepositionBottomRight();

            // 타이머 & 델리게이트
            TimerEvent = new System.Timers.Timer(10) { AutoReset = true };
            OnHeight = new OnDelegateHeight(MsgView);

            // 링크 클릭으로 즉시 닫히게
            lblResult.LinkClicked -= linkLabel1_LinkClicked;
            lblResult.LinkClicked += linkLabel1_LinkClicked;

            // 폼 로드시 슬라이드 인
            Load -= Form2_Load;
            Load += Form2_Load;

            // 패널 페인트는 선택적 (외곽선 등 그릴 때 사용)
            plBack.Paint -= panel2_Paint;
            plBack.Paint += panel2_Paint;
        }

        public Form2(string msg)
        {
        }

        // 우하단 배치 계산
        private void RepositionBottomRight()
        {
            var wa = Screen.PrimaryScreen.WorkingArea;
            Location = new System.Drawing.Point(
                wa.Right - Width - 20,
                wa.Bottom - Height - 20
            );
        }

        // ====== 이벤트 핸들러 ======
        private void Form2_Load(object sender, EventArgs e)
        {
            // 올라오기(팝업) 시작
            TimerEvent.Elapsed -= OnPopOut;
            TimerEvent.Elapsed -= OnPopUp;
            TimerEvent.Elapsed += OnPopUp;
            TimerEvent.Interval = 10;
            TimerEvent.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 즉시 종료
            Invoke(OnHeight, 2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // 필요 시 테두리 등 UI 그리기 (옵션)
            // e.Graphics.DrawRectangle(System.Drawing.Pens.Gray, panel2.ClientRectangle.X, panel2.ClientRectangle.Y, panel2.ClientRectangle.Width - 1, panel2.ClientRectangle.Height - 1);
        }

        // ====== 델리게이트로 호출되는 동작 전환 ======
        private void MsgView(int flag)
        {
            if (flag == 0)         // 올리기
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= OnPopOut;
                TimerEvent.Elapsed -= OnPopUp;
                TimerEvent.Elapsed += OnPopUp;
                TimerEvent.Interval = 10;
                TimerEvent.Start();
            }
            else if (flag == 1)    // 내리기
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= OnPopUp;
                TimerEvent.Elapsed -= OnPopOut;
                TimerEvent.Elapsed += OnPopOut;
                TimerEvent.Interval = 10;
                TimerEvent.Start();
            }
            else if (flag == 2)    // 종료
            {
                Close();
            }
        }

        // ====== 올라오는 애니메이션 ======
        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (IsDisposed) return;

                if (Height < TargetHeight)
                {
                    // UI 스레드 마샬링
                    if (InvokeRequired)
                    {
                        Invoke((Action)(() =>
                        {
                            Height = Math.Min(TargetHeight, Height + Step);
                            RepositionBottomRight();
                        }));
                    }
                    else
                    {
                        Height = Math.Min(TargetHeight, Height + Step);
                        RepositionBottomRight();
                    }
                }
                else
                {
                    // 다 올라오면 잠깐 정지 후 내려가기 전환
                    TimerEvent.Stop();

                    // 1.5초 대기 후 내리기
                    TimerEvent.Interval = 1500;
                    ElapsedEventHandler once = null;
                    once = (s, _) =>
                    {
                        TimerEvent.Elapsed -= once;   // 1회 실행
                        MsgView(1);                   // 내리기 시작
                    };
                    TimerEvent.Elapsed += once;
                    TimerEvent.Start();
                }
            }
            catch { /* ignore */ }
        }

        // ====== 내려가는 애니메이션 ======
        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (IsDisposed) return;

                while (Height > MinHeight)
                {
                    if (InvokeRequired)
                    {
                        Invoke((Action)(() =>
                        {
                            Height = Math.Max(MinHeight, Height - Step);
                            RepositionBottomRight();
                        }));
                    }
                    else
                    {
                        Height = Math.Max(MinHeight, Height - Step);
                        RepositionBottomRight();
                    }
                    System.Threading.Thread.Sleep(8); // 너무 급격한 변화 방지
                }

                TimerEvent.Stop();
                Invoke(OnHeight, 2); // 완전히 내려가면 종료
            }
            catch { /* ignore */ }
        }
    }
}
