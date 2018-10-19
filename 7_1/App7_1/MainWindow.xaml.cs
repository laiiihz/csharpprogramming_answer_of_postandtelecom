using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App7_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Data
        {
            public int min { get; set; }
            public int max { get; set; }
            public int avr { get; set; }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text1.Text = "";
            Data d = new Data(); 
            d.avr = 0;
            Random random = new Random((int)DateTime.Now.Millisecond);
            int[] a = new int[20];
            for (int i = 0; i < 20; i++)
            {
                a[i] = random.Next(0, 501);
                Text1.Text = Text1.Text + " " + a[i];
                d.avr += a[i];
            }
            ArrayList list = new ArrayList(a);
            list.Sort();
            d.min = (int)list[0];
            d.max = (int)list[19];
            d.avr = d.avr / 20;
            text_min.DataContext = d;
            text_avr.DataContext = d;
            text_max.DataContext = d;

            if (d.max > 255)
            {
                rc_max.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else rc_max.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            if (d.min > 255)
            {
                rc_min.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else rc_min.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            if (d.avr > 255)
            {
                rc_avr.Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else rc_avr.Stroke = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
