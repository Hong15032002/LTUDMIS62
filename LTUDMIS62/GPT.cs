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
    public partial class GPT : Form
    {
        public GPT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Double a, b, c, d, x1, x2;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            d=b*b-4*a*c;
            if(d<0)
            {
                lblKQ.Text = "Phương trình vô nghiệm!";
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                lblKQ.Text = " x1= " + Convert.ToString(x1) + ", x2= " + Convert.ToString(x2);
            }    
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
