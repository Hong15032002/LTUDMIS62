using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUDMIS62
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPT f = new GPT();
            f.Show(); 
        }

        private void táchTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TachTen f = new TachTen();
            f.Show();
        }

        private void máyTínhBấmTayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MayTinh f = new MayTinh();
            f.Show();
        }

        private void đồngHồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatch f = new StopWatch();
            f.Show();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giảiPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPT f = new GPT();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Status1.Text = "Giải phương trình bậc 2 "; 
            GPT f = new GPT();
            f.ShowDialog();
            Status1.Text = "Ready!";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Status3.Text = "Thời gian hệ thống: " + System.DateTime.Now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhMụcHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDMHH f = new FrmDMHH();
            f.Show();
        }
    }
}
