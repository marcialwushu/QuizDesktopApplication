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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //play.Stop();
        }
        //System.Media.SoundPlayer play = new System.Media.SoundPlayer(@"C:\Users\carlosjunior\Desktop\won.mp3");

        private void Form3_Load(object sender, EventArgs e)
        {
            //play.Play();
        }
    }
}
