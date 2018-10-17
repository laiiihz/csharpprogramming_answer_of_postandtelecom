using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsDesktopApp_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

           
            timer1.Enabled = true;
            timer1.Interval = int.Parse(textBox3.Text.ToString());
            timer1.Start();
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int min = int.Parse(textBox1.Text.ToString());
            int max = int.Parse(textBox2.Text.ToString());
            
            if (radioButton1.Checked == true)
            {
                int randomNum = RandomHelp.GetIntRandomNumber(min, max);
                label_result.Text = randomNum.ToString();
            } else if(radioButton2.Checked == true){
                double randomNum = RandomHelp.GetDoubleRandomNumber(min, max);
                label_result.Text = randomNum.ToString();
            }
            
            
        }
    }
}
