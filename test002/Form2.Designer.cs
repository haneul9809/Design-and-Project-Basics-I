namespace test002
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn빗소리ASMR = new System.Windows.Forms.Button();
            this.btnNoASMR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aSMR선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빗소리재생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.숲소리재생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSMR끄기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForestASMR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn빗소리ASMR
            // 
            this.btn빗소리ASMR.BackColor = System.Drawing.Color.White;
            this.btn빗소리ASMR.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn빗소리ASMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn빗소리ASMR.Location = new System.Drawing.Point(83, 414);
            this.btn빗소리ASMR.Name = "btn빗소리ASMR";
            this.btn빗소리ASMR.Padding = new System.Windows.Forms.Padding(5);
            this.btn빗소리ASMR.Size = new System.Drawing.Size(260, 110);
            this.btn빗소리ASMR.TabIndex = 16;
            this.btn빗소리ASMR.Text = "빗소리 재생";
            this.btn빗소리ASMR.UseVisualStyleBackColor = false;
            this.btn빗소리ASMR.Click += new System.EventHandler(this.btn빗소리ASMR_Click);
            // 
            // btnNoASMR
            // 
            this.btnNoASMR.BackColor = System.Drawing.Color.White;
            this.btnNoASMR.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNoASMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoASMR.Location = new System.Drawing.Point(724, 414);
            this.btnNoASMR.Name = "btnNoASMR";
            this.btnNoASMR.Size = new System.Drawing.Size(260, 110);
            this.btnNoASMR.TabIndex = 15;
            this.btnNoASMR.Text = "수면 측정 시작";
            this.btnNoASMR.UseVisualStyleBackColor = false;
            this.btnNoASMR.Click += new System.EventHandler(this.btnNoASMR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSMR선택ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aSMR선택ToolStripMenuItem
            // 
            this.aSMR선택ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빗소리재생ToolStripMenuItem,
            this.숲소리재생ToolStripMenuItem,
            this.aSMR끄기ToolStripMenuItem});
            this.aSMR선택ToolStripMenuItem.Name = "aSMR선택ToolStripMenuItem";
            this.aSMR선택ToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.aSMR선택ToolStripMenuItem.Text = "ASMR 선택";
            // 
            // 빗소리재생ToolStripMenuItem
            // 
            this.빗소리재생ToolStripMenuItem.Name = "빗소리재생ToolStripMenuItem";
            this.빗소리재생ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.빗소리재생ToolStripMenuItem.Text = "빗소리 재생";
            this.빗소리재생ToolStripMenuItem.Click += new System.EventHandler(this.빗소리재생ToolStripMenuItem_Click);
            // 
            // 숲소리재생ToolStripMenuItem
            // 
            this.숲소리재생ToolStripMenuItem.Name = "숲소리재생ToolStripMenuItem";
            this.숲소리재생ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.숲소리재생ToolStripMenuItem.Text = "숲소리 재생";
            this.숲소리재생ToolStripMenuItem.Click += new System.EventHandler(this.숲소리재생ToolStripMenuItem_Click);
            // 
            // aSMR끄기ToolStripMenuItem
            // 
            this.aSMR끄기ToolStripMenuItem.Name = "aSMR끄기ToolStripMenuItem";
            this.aSMR끄기ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.aSMR끄기ToolStripMenuItem.Text = "ASMR 끄기";
            this.aSMR끄기ToolStripMenuItem.Click += new System.EventHandler(this.aSMR끄기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // btnForestASMR
            // 
            this.btnForestASMR.BackColor = System.Drawing.Color.White;
            this.btnForestASMR.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnForestASMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForestASMR.Location = new System.Drawing.Point(403, 414);
            this.btnForestASMR.Name = "btnForestASMR";
            this.btnForestASMR.Padding = new System.Windows.Forms.Padding(5);
            this.btnForestASMR.Size = new System.Drawing.Size(260, 110);
            this.btnForestASMR.TabIndex = 18;
            this.btnForestASMR.Text = "숲소리 재생";
            this.btnForestASMR.UseVisualStyleBackColor = false;
            this.btnForestASMR.Click += new System.EventHandler(this.btnForestASMR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::test002.Properties.Resources.asmr;
            this.pictureBox1.Location = new System.Drawing.Point(417, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnForestASMR);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn빗소리ASMR);
            this.Controls.Add(this.btnNoASMR);
            this.Name = "Form2";
            this.Text = "수면 패턴 분석(Sleep Pattern Analysis)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn빗소리ASMR;
        private System.Windows.Forms.Button btnNoASMR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aSMR선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빗소리재생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 숲소리재생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSMR끄기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Button btnForestASMR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}