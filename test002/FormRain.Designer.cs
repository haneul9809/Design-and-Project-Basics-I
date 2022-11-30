namespace test002
{
    partial class FormRain
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
            this.btnRainStop = new System.Windows.Forms.Button();
            this.btnRainPlay = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRainStop
            // 
            this.btnRainStop.BackColor = System.Drawing.Color.White;
            this.btnRainStop.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRainStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRainStop.Location = new System.Drawing.Point(596, 443);
            this.btnRainStop.Name = "btnRainStop";
            this.btnRainStop.Padding = new System.Windows.Forms.Padding(5);
            this.btnRainStop.Size = new System.Drawing.Size(260, 110);
            this.btnRainStop.TabIndex = 21;
            this.btnRainStop.Text = "빗소리 종료";
            this.btnRainStop.UseVisualStyleBackColor = false;
            this.btnRainStop.Click += new System.EventHandler(this.btnRainStop_Click);
            // 
            // btnRainPlay
            // 
            this.btnRainPlay.BackColor = System.Drawing.Color.White;
            this.btnRainPlay.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRainPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRainPlay.Location = new System.Drawing.Point(276, 443);
            this.btnRainPlay.Name = "btnRainPlay";
            this.btnRainPlay.Padding = new System.Windows.Forms.Padding(5);
            this.btnRainPlay.Size = new System.Drawing.Size(260, 110);
            this.btnRainPlay.TabIndex = 20;
            this.btnRainPlay.Text = "빗소리 재생";
            this.btnRainPlay.UseVisualStyleBackColor = false;
            this.btnRainPlay.Click += new System.EventHandler(this.btnRainPlay_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(276, 342);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(580, 56);
            this.trackBar2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 23;
            // 
            // FormRain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.btnRainStop);
            this.Controls.Add(this.btnRainPlay);
            this.Name = "FormRain";
            this.Text = "수면 패턴 분석(Sleep Pattern Analysis)_빗소리 ASMR";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRainStop;
        private System.Windows.Forms.Button btnRainPlay;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox textBox1;
    }
}