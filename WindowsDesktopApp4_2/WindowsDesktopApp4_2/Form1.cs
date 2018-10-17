using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsDesktopApp4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox2.Text, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog = openFileDialog1;
            dialog.ShowDialog();
            textBox2.Text = dialog.FileName;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") return;
            textBox1.Text = "";
            FileStream fs = new FileStream(textBox2.Text,FileMode.Open);
            StreamReader str = new StreamReader(fs);
            string one_line;
            while ((one_line =str.ReadLine()) != null)
            {
                textBox1.Text += one_line;
                textBox1.Text += "\r\n";
            }
            str.Close();
            fs.Close();
        }
    }
}
