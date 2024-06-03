using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt3
{
    public partial class Form3 : Form

    {
        public Form3()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 10000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();

            timer2 = new Timer();
            timer2.Interval = 15000; 
            timer2.Tick += timer2_Tick;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
