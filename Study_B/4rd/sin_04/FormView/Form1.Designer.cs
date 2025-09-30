namespace FormView
{
    partial class Form1   // 여기서도 partial로 이어져야 함
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 리소스를 정리합니다.
        /// </summary>
        protected override void Dispose(bool disposing)   // 이 부분은 자동 생성됨
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.bntModal = new System.Windows.Forms.Button();
            this.bntModaless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntModal
            // 
            this.bntModal.Location = new System.Drawing.Point(456, 128);
            this.bntModal.Name = "bntModal";
            this.bntModal.Size = new System.Drawing.Size(75, 23);
            this.bntModal.TabIndex = 0;
            this.bntModal.Text = "모달";
            this.bntModal.UseVisualStyleBackColor = true;
            this.bntModal.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntModaless
            // 
            this.bntModaless.Location = new System.Drawing.Point(456, 172);
            this.bntModaless.Name = "bntModaless";
            this.bntModaless.Size = new System.Drawing.Size(75, 23);
            this.bntModaless.TabIndex = 1;
            this.bntModaless.Text = "모달리스";
            this.bntModaless.UseVisualStyleBackColor = true;
            this.bntModaless.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntModaless);
            this.Controls.Add(this.bntModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "폼 꾸미기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bntModal;
        private System.Windows.Forms.Button bntModaless;
    }
}
