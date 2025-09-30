namespace FontControl
{
    partial class Form1
    {
        /// <summary>필수 디자이너 변수</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>리소스 정리</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnColor = new System.Windows.Forms.ToolStripButton();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.fontDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFont,
            this.tsbtnColor});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(800, 27);
            this.tlsMenu.TabIndex = 0;
            this.tlsMenu.Text = "tlsMenu";
            // 
            // tsbtnFont
            // 
            this.tsbtnFont.Name = "tsbtnFont";
            this.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            // 임시 아이콘(원하시는 PNG로 교체 가능)
            this.tsbtnFont.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            this.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFont.Size = new System.Drawing.Size(29, 24);
            this.tsbtnFont.ToolTipText = "글꼴 선택";
            this.tsbtnFont.Click += new System.EventHandler(this.tsbtnFont_Click);
            // 
            // tsbtnColor
            // 
            this.tsbtnColor.Name = "tsbtnColor";
            this.tsbtnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            // 임시 아이콘(원하시는 PNG로 교체 가능)
            this.tsbtnColor.Image = System.Drawing.SystemIcons.Question.ToBitmap();
            this.tsbtnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColor.Size = new System.Drawing.Size(29, 24);
            this.tsbtnColor.ToolTipText = "색상 선택";
            this.tsbtnColor.Click += new System.EventHandler(this.tsbtnColor_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 27);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(800, 423);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            // 
            // fontDlg
            // 
            this.fontDlg.ShowColor = false; // 색상은 ColorDialog로 관리
            // 
            // colorDlg
            // 
            // 기본값 그대로 사용
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tlsMenu);
            this.Name = "Form1";
            this.Text = "폰트 꾸미기";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripButton tsbtnFont;
        private System.Windows.Forms.ToolStripButton tsbtnColor;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.FontDialog fontDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
    }
}
