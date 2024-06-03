using System;
using System.Drawing; 
using System.Windows.Forms;

namespace projekt3
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        private Timer timer = new Timer();

        public Form2()
        {
            InitializeComponent();
            timer.Interval = 1250; 
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            timer2.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            DisplayRandomNumber(55, 100, 1);
            DisplayRandomNumber(1, 15, 2);
            DisplayRandomNumber(300, 1000, 3);
        }
        private void DisplayRandomNumber(int min, int max, int a)
        {
            int randomNumber = random.Next(min, max + 1);
            if(a == 1)
            {
                label1.Text = randomNumber.ToString();

                
                if (randomNumber <= 85)
                {
                    label1.ForeColor = Color.Green; 
                }
                else
                {
                    label1.ForeColor = Color.Red; 
                }
            }
            else if (a == 2)
            {
                label2.Text = randomNumber.ToString();

                
                if (randomNumber <= 10)
                {
                    label2.ForeColor = Color.Green; 
                }
                else
                {
                    label2.ForeColor = Color.Red; 
                }
            }
            else if (a == 3)
            {
                label3.Text = randomNumber.ToString();

                
                if (randomNumber <= 800 && randomNumber >= 500)
                {
                    label3.ForeColor = Color.Green; 
                }
                else
                {
                    label3.ForeColor = Color.Red; 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayRandomNumber(55, 85, 1);
            timer.Stop();
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayRandomNumber(1, 10, 2);
            timer.Stop();
            timer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayRandomNumber(500, 800, 3);
            timer.Stop();
            timer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            AttendanceCheck();
        }
        private void AttendanceCheck()
        {
            Form3 f3 = new Form3();
            f3.TopMost = true;
            f3.Show();
        }
    }
}
