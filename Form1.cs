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
    public partial class Form1 : Form
    {
        string username = Environment.UserName;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Granie Jako: " + username;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Form2();
            m.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            string username = Environment.UserName;
            
        }
        

    }
}
