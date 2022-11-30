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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            //this.Visible = false;             // 추가
            //Form2 dlg = new Form2();
            //dlg.ShowDialog();

        private void btnQuik_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("수면 패턴 분석(Sleep Pattern Analysis) 프로그램을 종료합니다."); 
            this.Close();
        }

        private void 종료ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 dlg = new Form2();
            dlg.ShowDialog();
            this.Close();
        }

        private void 측정시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 dlg = new Form2();
            dlg.ShowDialog();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 dlg = new Form4();
            dlg.ShowDialog();
            this.Close();
        }

        private void 레포트확인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 dlg = new Form4();
            dlg.ShowDialog();
            this.Close();
        }
    }
}
