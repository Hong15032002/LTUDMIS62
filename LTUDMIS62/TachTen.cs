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
    public partial class TachTen : Form
    {
        string ht, kq;
        int vt1, vt2;
        public TachTen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHoDem_Click(object sender, EventArgs e)
        {
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            kq = ht.Substring(0, vt1);
            kq = ("Họ đệm: " + kq);
            lblKQ.Text = kq;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTachDem_Click(object sender, EventArgs e)
        {
                 ht = txtHT.Text.Trim();
                vt1 = ht.IndexOf(" ");
                vt2 = ht.LastIndexOf(" ");
                kq = ht.Substring(vt1, vt2 - vt1);
                kq = ("Đệm: " + kq);
                lblKQ.Text = kq;

        }

        private void btnTachDEMTEN_Click(object sender, EventArgs e)
        {
            string ten, hodem;
            ht = txtHT.Text.Trim();
            vt1 = ht.LastIndexOf(" ");
            hodem= ht.Substring(0, vt1);
            ten = ht.Substring(vt1, txtHT.TextLength - vt1);
            kq= ("Họ đệm: "+ hodem + "\n" + "Tên: " + ten);
            lblKQ.Text = kq;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TachTen_Load(object sender, EventArgs e)
        {

        }
    }
}

