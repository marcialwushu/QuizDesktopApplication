using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDesktopApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Random a1 = new Random();
            int ran1 = a1.Next(1, 5);
            if (ran1 == 1)
            {
                textBox1.Text = "Who is the prime minister of Pakistan";
                button1.Text = "A) Nawaz sharif";
                button2.Text = "B) Yousuf Raza Gilani";
                button3.Text = "C) Pervaz Musarraf";
                button4.Text = "D) Zardani";
            }
            else if (ran1 == 2)
            {
                textBox1.Text = "When pakistan won ODI World Cup";
                button1.Text = "A) 1992";
                button2.Text = "B) 1993";
                button3.Text = "C) 1994";
                button4.Text = "D) 1995";
            }
            else if (ran1 == 3)
            {
                textBox1.Text = "When pakistan won ODI World Cup";
                button1.Text = "A) 1992";
                button2.Text = "B) 1993";
                button3.Text = "C) 1994";
                button4.Text = "D) 1995";
            }
            else if (ran1 == 4)
            {
                textBox1.Text = "When pakistan won ODI World Cup";
                button1.Text = "A) 1992";
                button2.Text = "B) 1993";
                button3.Text = "C) 1994";
                button4.Text = "D) 1995";
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
