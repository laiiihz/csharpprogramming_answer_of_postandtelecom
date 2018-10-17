using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktopApp4_1
{
    
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>() {  new Person { age=23,name="lhz",phone="10193854390"},
                                                    new Person{age=14,name="qds",phone="732461451"},
                                                    new Person{age=20,name="李1s",phone="73246956781"},
                                                    new Person{age=19,name="q2s",phone="732874561"},
                                                    new Person{age=17,name="q3s",phone="732345234651"}
                                                    };
        public Form1()
        {
            InitializeComponent();
        }

       private void show1()
        {
            listBox1.Items.Clear();
            foreach (Person man in people)
            {
                listBox1.Items.Add(man.Print());
            }

        }
        private void show2()
        {
            listBox1.Items.Clear();

            var peop =
                from a in people
                where a.age >= 18 && a.age <= 25
                select a;
            foreach (Person man in peop)
            {
                listBox1.Items.Add(man.Print());
            }

        }
        private void show3()
        {
            listBox1.Items.Clear();

            var peop =
               from a in people
               where a.name.Substring(0, 1) == "李"
               select a;
            foreach (Person man in peop)
            {
                listBox1.Items.Add(man.Print());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                show1();
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                show2();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private void panel1_Paint(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) { show3(); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
