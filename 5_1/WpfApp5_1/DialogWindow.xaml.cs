using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WpfApp5_1
{
    /// <summary>
    /// DialogWindow.xaml 的交互逻辑
    /// </summary>
    
    public partial class DialogWindow : Window
    {
        public string GetWords { get; set; }
        public DialogWindow()
        {
           
            InitializeComponent();


        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string a = GetWords;
            string[] result = Regex.Split(a, "%%", RegexOptions.IgnoreCase);
            for(int i = 0; i < 3; i++)
            {
                lb_1.Content =lb_1.Content+result[i]+"\r\n";
            }
        }
    }
}
