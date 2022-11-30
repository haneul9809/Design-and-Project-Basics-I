namespace test002
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuik = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.측정시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레포트확인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test002.Properties.Resources.moon;
            this.pictureBox1.Location = new System.Drawing.Point(458, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuik
            // 
            this.btnQuik.BackColor = System.Drawing.Color.White;
            this.btnQuik.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnQuik.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuik.Location = new System.Drawing.Point(778, 440);
            this.btnQuik.Name = "btnQuik";
            this.btnQuik.Padding = new System.Windows.Forms.Padding(5);
            this.btnQuik.Size = new System.Drawing.Size(260, 110);
            this.btnQuik.TabIndex = 13;
            this.btnQuik.Text = "종료";
            this.btnQuik.UseVisualStyleBackColor = false;
            this.btnQuik.Click += new System.EventHandler(this.btnQuik_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReport.Location = new System.Drawing.Point(437, 440);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(5);
            this.btnReport.Size = new System.Drawing.Size(260, 110);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "레포트 확인";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.Location = new System.Drawing.Point(98, 440);
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(5);
            this.btnStart.Size = new System.Drawing.Size(260, 110);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "측정 시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.측정시작ToolStripMenuItem,
            this.레포트확인ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 측정시작ToolStripMenuItem
            // 
            this.측정시작ToolStripMenuItem.Name = "측정시작ToolStripMenuItem";
            this.측정시작ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.측정시작ToolStripMenuItem.Text = "측정시작";
            this.측정시작ToolStripMenuItem.Click += new System.EventHandler(this.측정시작ToolStripMenuItem_Click);
            // 
            // 레포트확인ToolStripMenuItem
            // 
            this.레포트확인ToolStripMenuItem.Name = "레포트확인ToolStripMenuItem";
            this.레포트확인ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.레포트확인ToolStripMenuItem.Text = "레포트확인";
            this.레포트확인ToolStripMenuItem.Click += new System.EventHandler(this.레포트확인ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnQuik);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "수면 패턴 분석(Sleep Pattern Analysis)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuik;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 측정시작ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레포트확인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

