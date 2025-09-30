namespace A_Timer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button(); // ← 이름 수정
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(89, 38);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 25);
            this.txtNum.TabIndex = 0;
            // 필요 없으면 TextChanged 핸들러 제거
            // this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCountDown
            // 
            this.txtCountDown.Location = new System.Drawing.Point(89, 114);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(100, 25);
            this.txtCountDown.TabIndex = 1;
            // 필요 없으면 TextChanged 핸들러 제거
            // this.txtCountDown.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(312, 38);
            this.btnCount.Name = "btnCount"; // ← 이름 통일
            this.btnCount.Size = new System.Drawing.Size(107, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "카운트다운";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click); // ← Click 연결
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick); // ← 이름 통일 (timer1_Tick → Timer_Tick)
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 183);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "타이머";
            // Form1_Load가 없다면 아래 줄을 제거하세요.
            // this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnCount;   // ← 필드명도 btnCount로
        private System.Windows.Forms.Timer Timer;
    }
}
