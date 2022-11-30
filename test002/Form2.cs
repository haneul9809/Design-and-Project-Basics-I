using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test002
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoASMR_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 dlg = new Form3();
            dlg.ShowDialog();
            this.Close();
        }

        private void btn빗소리ASMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("빗소리를 1시간 가량 재생합니다");
            FormRain dlg = new FormRain();
            dlg.ShowDialog();
        }

        private void 빗소리재생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("빗소리를 1시간 가량 재생합니다");
            FormRain dlg = new FormRain();
            dlg.ShowDialog();
        }

        private void 숲소리재생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("숲소리를 1시간 가량 재생합니다");
            FormForest dlg = new FormForest();
            dlg.ShowDialog();
        }

        private void aSMR끄기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 dlg = new Form3();
            this.Close();
        }

        private void btnForestASMR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("숲소리를 1시간 가량 재생합니다");
            //this.Visible = false;
            FormForest dlg = new FormForest();
            dlg.ShowDialog();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
        //simpleSound.Play();
    }
}
