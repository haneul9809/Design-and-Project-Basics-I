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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void 메인화면으로돌아가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메인 화면으로 돌아갑니다.");
            this.Visible = false;
            Form1 dlg = new Form1();
            dlg.ShowDialog();
            this.Close();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수면 패턴 분석(Sleep Pattern Analysis) 프로그램을 종료합니다.");
            Form2 dlg2 = new Form2();
            dlg2.Close();
            this.Close();
        }
    }
}
