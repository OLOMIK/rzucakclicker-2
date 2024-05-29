using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlomowoRzucakClicker
{
    public partial class Form4 : Form
    {
        Settings1 Settings;
        public int x = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Clicki: " + x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(x >= 100)
            {
                pictureBox1.Image = pictureBox4.Image;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (x >= 1000)
            {
                pictureBox1.Image = pictureBox5.Image;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (x >= 10000)
            {
                pictureBox1.Image = pictureBox6.Image;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (x >= 100000)
            {
                pictureBox1.Image = pictureBox3.Image;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (x >= 1000000)
            {
                pictureBox1.Image = pictureBox2.Image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x > 10000)
            {
                x = x + 20000;
                try
                {
                    Settings.Wynik = x + 20000;
                }
                catch
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd", "RzucakClicker");
                }
                

            }
        }
    }
}
