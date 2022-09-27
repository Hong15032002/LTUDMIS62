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
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
        }
        int count = 0, minutes = 0, hours=0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 60)
            {
                minutes++;
                if (minutes.ToString().Length == 1)
                {
                    lblMinutes.Text = "0" + minutes.ToString();
                } else
                {
                    lblMinutes.Text = minutes.ToString();
                }
                count = 0;
            }
            lblSeconds.Text = count.ToString();
            if (minutes >= 60)
            {
                hours++;
                if (hours.ToString().Length == 1)
                {
                    lblHours.Text = "0" + hours.ToString();
                }
                else
                {
                    lblHours.Text = hours.ToString();
                }
                minutes = 0;
            }
            if (count.ToString().Length == 1)
            {
                lblSeconds.Text = "0" + count.ToString();
            }
            else
            {
                lblSeconds.Text = count.ToString();
            }
            
        }

      

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            minutes = 0;
            hours = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrCount.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrCount.Stop();
        }

    }
}
