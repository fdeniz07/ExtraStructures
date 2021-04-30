using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 0;
            timer1.Start();

        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s1 = 0, s2 = 0, s3 = 0;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (sayac % 2 == 0)
                {
                    s1 = rnd.Next(1, 5);
                    s2 = rnd.Next(1, 5);
                    s3 = rnd.Next(1, 5);
                }
                label1.Text = s1.ToString();
                label2.Text = s2.ToString();
                label3.Text = s3.ToString();
                sayac++;
                label4.Text = sayac.ToString();
            }
           

            if (sayac == 1000)
            {
                timer1.Stop();
            }
        }
    }
}
