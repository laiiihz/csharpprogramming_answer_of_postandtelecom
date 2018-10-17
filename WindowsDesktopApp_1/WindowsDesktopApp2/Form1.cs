using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktopApp2
{
    public partial class Form1 : Form
    {
        int mark = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "+";
            mark = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "-";
            mark = 2;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "*";
            mark = 3;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "/";
            mark = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text_box_1=textBox1.Text.ToString();
            string text_box_2 = textBox2.Text.ToString();
            long text_1 = Convert.ToInt64(text_box_1);
            long text_2 = Convert.ToInt64(text_box_2);
            long result=0;
            bool zero_mark = false;
            switch (mark)
            {
                case 1:
                    result = text_1 + text_2;
                    break;
                case 2:
                    result = text_1 - text_2;
                    break;
                case 3:
                    result = text_1 * text_2;
                    break;
                case 4:
                    if (text_2 == 0)
                    {
                        zero_mark = true;
                        break;
                    }
                    result = text_1 / text_2;
                    break;
                case 5:
                    result = text_1 % text_2;
                    break;
            }
            if (zero_mark == true) textBox3.Text = "无法计算";
            else textBox3.Text = result.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "%";
            mark = 5;

        }
    }
}
