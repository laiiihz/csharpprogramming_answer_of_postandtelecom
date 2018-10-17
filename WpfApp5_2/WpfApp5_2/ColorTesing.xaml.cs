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

namespace WpfApp5_2
{
    /// <summary>
    /// ColorTesing.xaml 的交互逻辑
    /// </summary>
    public partial class ColorTesing : Window
    {
        public string getString { get; set; }
        public ColorTesing()
        {
            InitializeComponent();
        }

        private void Btn_y_Click(object sender, RoutedEventArgs e)
        {
            getString=text_head.Text;
            text_all.Text = getString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text_all.FontSize +=1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text_all.FontSize -= 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);
            text_all.Foreground = new SolidColorBrush(Color.FromRgb(r,g,b));
        }
    }
}
