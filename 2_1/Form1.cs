using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktopApp_1
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

        private void displaypsw_CheckedChanged(object sender, EventArgs e)
        {
            if (displaypsw_check.CheckState == CheckState.Checked)
            {
                textbox_display.Text = textbox_psw.Text;
                textbox_psw.TextChanged += new EventHandler(textbox_psw_TextChanged);
            }
            else textbox_display.Text = " ";
            
        }

        void textbox_psw_TextChanged(object sender, EventArgs e)
        {
            textbox_display.Text = textbox_psw.Text;
        }
    }
}
