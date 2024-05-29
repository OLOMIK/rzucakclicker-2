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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainform = new Form2();
            mainform.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
