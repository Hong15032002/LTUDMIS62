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
    public partial class MayTinh : Form
    {
        public MayTinh()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + "9";
        }

        private void btnCHAM_Click(object sender, EventArgs e)
        {
            txtHienThi1.Text = txtHienThi1.Text + ".";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtHienThi1.Clear();
            txtHienThi2.Clear();
        }
    }
}
