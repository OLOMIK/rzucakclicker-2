using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Net;
using System.IO;
namespace OlomowoRzucakClicker
{
    
    public partial class Form2 : Form
    {
        public int kapsula;
        public int c = 0;
        
        public Form2()
        {
            InitializeComponent();
            string username = Environment.UserName;
        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kapsula = kapsula + 2;
            label1.Text = "Clicki: " + kapsula;
            
            label1.Update();
            if (kapsula > 10000)
            {
                label1.Location = new Point(100, 90);


            }
        }
        
        //odwolanie: start programu
        private void Form2_Load(object sender, EventArgs e)
        {
            
            string user = Environment.UserName;
            Settings1 settings1 = new Settings1();
            settings1["Username"] = user;
            settings1.Save();
         
            
        }
      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

      
        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Form3();
            m.Show();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Settings1 settings1 = new Settings1();
            settings1["Wynik"] = kapsula;
            settings1.Save();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(IncreaseProgressBar);
            c = 0;
            label2.Text = "Odliczanie Rozpoczęte!";


        }
        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            timer1.Stop();
           
            label2.Text = "W 10 sekund zrobiłeś: " + c.ToString() + " Clicków!"; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
            
            

            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            kapsula = kapsula + 1000;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //odwolanie: przycisk rzucak
        private void Rzucak_Click(object sender, EventArgs e)
        {
            if(kapsula >= 1000000)
            {
                button5.Show();
            }
            string user = Environment.UserName;
            kapsula++;
            c++;
            label1.Text = "Clicki: " + kapsula;
            label1.Update();

            if (kapsula > 10000)
            {
                label1.Location = new Point(100, 90);

            }

            try
            {
                if (File.Exists(Application.StartupPath + @"\Points.txt"))
                {
                    File.WriteAllText(Application.StartupPath + @"\Points.txt", "Punkty: " + kapsula + "Gracz: " + user);

                }
                else
                {
                    File.WriteAllText(Application.StartupPath + @"\Points.txt", "Punkty: " + kapsula + "Gracz: " + user);
                }
            }
            catch
            {

                MessageBox.Show("RzucakClicker Potrzebuje Uprawnień Admininstratora!" , "RzucakClicker");

            }


            
            

                

        }
        
        static readonly System.Net.Http.HttpClient client = new HttpClient();
        //odwolanie: tablica wynikow
      
        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings1 settings1 = new Settings1();
            kapsula = (int)settings1["Wynik"];
            label1.Text = "Clicki: " + settings1["Wynik"].ToString();
        }
        //odwolanie: zamkniecie programu 
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
  
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.x = kapsula;
            x.ShowDialog();
            if(x.DialogResult == DialogResult.OK)
            {
                Rzucak.Image = x.pictureBox1.Image;  

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(kapsula > 50000)
            {
                while (kapsula < 1000000000)
                {
                    kapsula++;
                    label1.Update();
                }
            }
            else
            {
                label3.Text = "Aby uruchomić autoclickera\nmusisz osiągnąć 50k clicków.";
            }
     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kapsula = kapsula + 100000000;
            label1.Update();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var pomocwindow = new help();
            pomocwindow.ShowDialog();
        }
    }
}













































































































































































































