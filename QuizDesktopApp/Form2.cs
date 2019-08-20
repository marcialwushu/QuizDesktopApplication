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
            if (textBox1.Text == "Who is the founder of pakistan" || textBox1.Text == "The largest coffee growing country in the world is ?")
            {
                Random a3 = new Random();
                int ran3 = a3.Next(1, 3);
                if (ran3 == 1)
                {
                    score = 3000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "When state bank of Pakistan established";
                    button1.Text = "A) 1947";
                    button2.Text = "B) 1948";
                    button3.Text = "C) 1949";
                    button4.Text = "D) 1950";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran3 == 2)
                {
                    score = 3000;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Which is the National Game of Pakistan";
                    button1.Text = "A) Hockey";
                    button2.Text = "B) Cricket";
                    button3.Text = "C) Football";
                    button4.Text = "D) Tannis";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }
            }
            else if (textBox1.Text == "Who is Governer of Sindh")
            {
                score = 40000;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "Who is the founder of Facebook";
                button1.Text = "A) Markoni";
                button2.Text = "B) Mekintosh";
                button3.Text = "C) Mark Zuckerberg";
                button4.Text = "D) James Pitter";
                label7.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "When china got independence")
            {
                score = 320000;
                button1.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "How many nishan-e-haider holders in pakistan";
                button1.Text = "A) 6";
                button2.Text = "B) 8";
                button3.Text = "C) 10";
                button4.Text = "D) 12";
                label10.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "When Menhmod Gaznavi born")
            {
                score = 2500000;
                button1.Enabled = true;
                button3.Enabled = true;
                textBox1.Text = "When Google was lounched";
                button1.Text = "A) 1998";
                button2.Text = "B) 1997";
                button3.Text = "C) 1996";
                button4.Text = "D) 1995";
                label3.BackColor = System.Drawing.Color.Indigo;
            }
            else
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Who Write the National anthem of Pakistan" || textBox1.Text == "Who is the famous Poet of Pakistan")
            {
                Random a4 = new Random();
                int ran4 = a4.Next(1, 3);
                if (ran4 == 1)
                {
                    score = 2000;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "Who is the founder of Pakistan";
                    button1.Text = "A) Allan Iqbal";
                    button2.Text = "B) Quid-e-Azam";
                    button3.Text = "C) Lyaqat Ali Khan";
                    button4.Text = "D) Molvi Abdul Haq";
                    label3.BackColor = System.Drawing.Color.Indigo;
                }
                else if (ran4 == 2)
                {
                    score = 2000;
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Text = "The largest coffee growing country in the world is ?";
                    button1.Text = "A) KENIA";
                    button2.Text = "B) BRAZIL";
                    button3.Text = "C) ISTAMBUL";
                    button4.Text = "D) ENGLAND";
                    label2.BackColor = System.Drawing.Color.Indigo;
                }
            }
            else if (textBox1.Text == "Who is the founder of facebook")
            {
                score = 80000;
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "Total sixes hit by Shahid afridi";
                button1.Text = "A) 348";
                button2.Text = "B) 349";
                button3.Text = "C) 350";
                button4.Text = "D) 351";
                label8.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "how many nishan-e-haider holders in pakistan")
            {
                score = 625000;
                button2.Enabled = true;
                button4.Enabled = true;
                textBox1.Text = "When Mohammad bin Qasim Died";
                button1.Text = "A) 712";
                button2.Text = "B) 713";
                button3.Text = "C) 714";
                button4.Text = "D) 715";
                label11.BackColor = System.Drawing.Color.Indigo;
            }
            else if (textBox1.Text == "Who was the last Mughal ")
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();
                //player.Stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "When pakistan become atomic power")
            {

            }
        }
    }
}
