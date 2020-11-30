using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int scr = 0;
        int score = 0;
        Image img;
        string text;
        int Tno = 0;
        private int _tickets;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _tickets = 10;
            images();
            panel1.Hide();
           
        }
       
      
        public void images()
        {
            textBox1.Text = "";
            Tno = 5;
            text = "QUAID";
            textBox1.Text = "QUAI";
            textBox1.Enabled = false;
            img = Image.FromFile("places/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("places/3.jpg");
            this.pictureBox2.Image = img;
           
            img = Image.FromFile("places/4.jpg");
            this.pictureBox3.Image = img;
           
            img = Image.FromFile("places/2.jpg");
            this.pictureBox4.Image = img;
            
            button1.Text = "D";
            button2.Text = "E";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "O";
            button6.Text = "N";
            enable();
        }
        public void images1()
        {
          
            Tno = 6;
            textBox1.Text = "";
            text = "DOXTEN";
            textBox1.Text = "DOXTE";

            img = Image.FromFile("toys/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("toys/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("toys/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("toys/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "D";
            button2.Text = "O";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "E";
            button6.Text = "N";

            enable();

        }
        public void images2()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "DOXTEN";
            textBox1.Text = "DOXTE";

            img = Image.FromFile("persons/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("persons/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("persons/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("persons/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "D";
            button2.Text = "O";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "E";
            button6.Text = "N";
            enable();


        }
        public void images3()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "DOXTEN";
            textBox1.Text = "DOXTE";

            img = Image.FromFile("PC/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("PC/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("PC/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("PC/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "D";
            button2.Text = "O";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "E";
            button6.Text = "N";
            enable();


        }
        public void images4()
        {
            Tno = 6;
            textBox1.Text = "";
            text = "DOXTEN";
            textBox1.Text = "DOXTE";

            img = Image.FromFile("animal/1.jpg");
            this.pictureBox1.Image = img;

            img = Image.FromFile("animal/2.jpg");
            this.pictureBox2.Image = img;

            img = Image.FromFile("animal/3.jpg");
            this.pictureBox3.Image = img;

            img = Image.FromFile("animal/4.jpg");
            this.pictureBox4.Image = img;

            button1.Text = "D";
            button2.Text = "O";
            button3.Text = "X";
            button4.Text = "T";
            button5.Text = "E";
            button6.Text = "N";
            enable();


        }
       
        
      
        public void check()
        {
            score++;
            if(textBox1.Text == text)
            {
                MessageBox.Show("Correct Answer");
                scr++;
            }
            else if (textBox1.Text.Length == Tno && textBox1.Text != text)
            {
                MessageBox.Show("wrong");
            }
             
                
                if(score==1)
                {
                    images1();
                }
                else if(score==2)
                {
                    images2();
                }
                else if (score == 3)
                {
                    images3();
                }
                else if (score == 4)
                {
                    images4();
                    pop();
                }
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
            button1.Enabled = false;
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ button2.Text;
            button2.Enabled = false;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
            button3.Enabled = false;
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
            button4.Enabled = false;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
            button5.Enabled = false;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
            button6.Enabled = false;
            check();
        }
        public void enable()
        {
            _tickets = 60;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            _tickets--;
            this.Text = _tickets.ToString();
            label1.Text = this.Text;
            if (_tickets == 0)
            {

                timer1.Stop();
                MessageBox.Show("You Time is UP");
                Application.Exit();
            }

        }
        public void pop()
        {
            panel1.Show();
            label2.Text = "Your Score is " + scr;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
