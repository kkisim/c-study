using System;
using System.Windows.Forms;

namespace FormView
{
    internal static class Program
    {
        /// <summary>
        /// 애플리케이션의 메인 진입점
        /// </summary>
        [STAThread]   // Windows Forms에서는 필수
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1을 시작 폼으로 실행
            Application.Run(new Form1());
        }
    }
}
