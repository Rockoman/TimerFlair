using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerFlair
{
    public partial class Form1 : Form
    {

        string[] u = new string[] {"Click One", "Click Two", "Click Three", "Click Four", "Click Five"};
        int[] time = new int[] { 0, 0, 0, 0, 0 };
        int btnCount = 0;
        int s = 60;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (btnCount == 5)
            {
                s = 60;
                timer1.Start();
                lblResults.Text = " ";
                btnCount = 0;
                
            }
            
            if (lblSeconds.Text == "")
                lblSeconds.Text = "0";
                                    
                s = Convert.ToInt32(lblSeconds.Text);
                time[btnCount] = s;

                lblResults.Text += u[btnCount] + " stopped the clock at " + time[btnCount] + " seconds\n";

                btnCount += 1;
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            s = s - 1;
            string ss = Convert.ToString(s);
            lblSeconds.Text = ss;
            if (btnCount == 5)
            {
                timer1.Stop();

                MessageBox.Show("That's five times!");
                
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = 60;
            btnCount = 0;
            lblResults.Text = " ";
            lblSeconds.Text = "60";
            timer1.Stop();
            timer1.Start();
        }


    }
}
