using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktopApp_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             }

        private void Form1_Load(object sender, EventArgs e)
        {
            print();
        }

        private void print()
        {
            listBox1.Items.Add("课程名\t\t开课学期\t\t书名\t\t\t定价");
            CourseInfo[] courseInfos=new CourseInfo[4];
            Season Spring = Season.Spring;
            Season Autumn = Season.Autumn;
            courseInfos[0]= new CourseInfo("数据结构", Spring, "《数据结构》", 40.00);
            courseInfos[1] = new CourseInfo("操作系统",Autumn, "《操作系统》", 30.00);
            courseInfos[2] = new CourseInfo("软件工程", Spring, "《软件工程》", 20.00);
            courseInfos[3] = new CourseInfo("test test", Autumn, "《testtest》", 50.00);

            foreach (CourseInfo item_t in courseInfos)
            {
                string item = item_t.CourseNameTool+ "\t\t" + item_t.CourseTimeTool.ToString() + "\t\t" + item_t.BookNameTool + "\t\t" + item_t.PriceTool.ToString();
                listBox1.Items.Add(item);
            }
            //textBox1.Text =  + + +  + " " + GlobalNums.Counter;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
