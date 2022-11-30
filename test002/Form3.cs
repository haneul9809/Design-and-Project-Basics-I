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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수면 패턴 분석(Sleep Pattern Analysis)을 시작하겠습니다."); 
            this.Visible = false;
            Form4 dlg = new Form4();
            dlg.ShowDialog();
            this.Close();
        }

        private void 측정종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 dlg = new Form4();
            dlg.ShowDialog();
            this.Close();
        }
    }
}
