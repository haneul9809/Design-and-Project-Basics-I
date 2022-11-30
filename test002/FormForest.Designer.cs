namespace test002
{
    partial class FormForest
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
            this.btnForestStop = new System.Windows.Forms.Button();
            this.btnForestPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForestStop
            // 
            this.btnForestStop.BackColor = System.Drawing.Color.White;
            this.btnForestStop.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnForestStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForestStop.Location = new System.Drawing.Point(594, 437);
            this.btnForestStop.Name = "btnForestStop";
            this.btnForestStop.Padding = new System.Windows.Forms.Padding(5);
            this.btnForestStop.Size = new System.Drawing.Size(260, 110);
            this.btnForestStop.TabIndex = 23;
            this.btnForestStop.Text = "숲소리 종료";
            this.btnForestStop.UseVisualStyleBackColor = false;
            this.btnForestStop.Click += new System.EventHandler(this.btnForestStop_Click);
            // 
            // btnForestPlay
            // 
            this.btnForestPlay.BackColor = System.Drawing.Color.White;
            this.btnForestPlay.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnForestPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnForestPlay.Location = new System.Drawing.Point(274, 437);
            this.btnForestPlay.Name = "btnForestPlay";
            this.btnForestPlay.Padding = new System.Windows.Forms.Padding(5);
            this.btnForestPlay.Size = new System.Drawing.Size(260, 110);
            this.btnForestPlay.TabIndex = 22;
            this.btnForestPlay.Text = "숲소리 재생";
            this.btnForestPlay.UseVisualStyleBackColor = false;
            this.btnForestPlay.Click += new System.EventHandler(this.btnForestPlay_Click);
            // 
            // FormForest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1129, 681);
            this.Controls.Add(this.btnForestStop);
            this.Controls.Add(this.btnForestPlay);
            this.Name = "FormForest";
            this.Text = "수면 패턴 분석(Sleep Pattern Analysis)_숲소리 ASMR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForestStop;
        private System.Windows.Forms.Button btnForestPlay;
    }
}