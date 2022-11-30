using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace test002
{
    public partial class FormForest : Form
    {
        private SoundPlayer Player = new SoundPlayer();

        public FormForest()
        {
            InitializeComponent();
        }

        private void btnForestPlay_Click(object sender, EventArgs e)
        {
            this.Player.SoundLocation = @"C:\Users\skych\Desktop\forestASMR.wav";
            this.Player.Play();
        }

        private void btnForestStop_Click(object sender, EventArgs e)
        {
            this.Player.Stop();
            this.Visible = false;
            Form3 dlg = new Form3();
            dlg.ShowDialog();
            this.Close();
        }
    }
}
