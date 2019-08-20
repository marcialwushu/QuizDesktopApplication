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
                textBox1.Text = "Who is the President of PAF-KIET";
                button1.Text = "A) Tubrez Asif";
                button2.Text = "B) Khalid Khan";
                button3.Text = "C) Salman Ahmed";
                button4.Text = "D) Nafees Ahmad";
            }
            else if (ran1 == 4)
            {
                textBox1.Text = "Who won 2016 T20 World Cup";
                button1.Text = "A) West indes";
                button2.Text = "B) Australia";
                button3.Text = "C) India";
                button4.Text = "D) Pakistan";
            }
        }

        public static int score = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Who is the prime minister of Pakistan" || textBox1.Text == "When pakistan won ODI World Cup" || textBox1.Text == "Who is the President of PAF-KIET" || textBox1.Text == "Who won 2016 T20 World Cup")
            {
                Random a2 = new Random();
                int ran2 = a2.Next(1, 3);
                if (ran2 == 1)
                {
                    score = 1000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Who Write the National anthem of Pakistan";
                    button1.Text = "A) Allama  Iqbal";
                    button2.Text = "B) Sir syed Ahmad Khan";
                    button3.Text = "C) Hafiz Jalindhri";
                    button4.Text = "D) Molvi Abdul haq";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran2 == 2)
                {
                    score = 1000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Who Write the National anthem of Pakistan";
                    button1.Text = "A) Mirza Ghalib";
                    button2.Text = "B) Faraz Ahmad";
                    button3.Text = "C) Allama  Iqbal";
                    button4.Text = "D) Mir taqi mir";
                    label1.BackColor = System.Drawing.Color.Indigo;
                }

            }
            else if (textBox1.Text == "When state bank of Pakistan established" || textBox1.Text == "Which is the National Game of Pakistan")
            {
                score = 5000;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "When pakistan become atomic power";
                button1.Text = "A) 1995";
                button2.Text = "B) 1996";
                button3.Text = "C) 1997";
                button4.Text = "D) 1998";
                label4.BackColor = System.Drawing.Color.Indigo;

            }
            else if (textBox1.Text == "Who was the first president of pakistan")
            {
                score = 20000;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Who is the Governer of pakistan";
                button1.Text = "A) Qaim Ali Shah";
                button2.Text = "B) Eshrat Ul Ibad";
                button3.Text = "C) Mustafa kamal";
                button4.Text = "D) Hakim Mohammad Saeed";
                label6.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "When Google was lounched")
            {
                score = 5000000;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "Who was last Mughal empire of India";
                button1.Text = "A) Akbar";
                button2.Text = "B) Himayu";
                button3.Text = "C) Bahadur Shah Zafar";
                button4.Text = "D) Shah Jahan";
                label4.BackColor = System.Drawing.Color.Indigo;
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
