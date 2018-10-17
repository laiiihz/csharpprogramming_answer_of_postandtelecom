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
    /// MoveTesing.xaml 的交互逻辑
    /// </summary>
    public partial class MoveTesing : Window
    {
        int a = 317;
        int b = 161;
        public MoveTesing()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //Thickness magin = new Thickness(a, b, 0, 0);
            
            switch (e.Key)
            {
                case Key.Left:
                    a -= 5;
                    tb.Margin= new Thickness(a, b, 0, 0);
                    break;
                case Key.Right:
                    a += 5;
                    tb.Margin= new Thickness(a, b, 0, 0);
                    break;
                case Key.Up:
                    b -= 5;
                    tb.Margin= new Thickness(a, b, 0, 0); 
                    break;
                case Key.Down:
                    b += 5;
                    tb.Margin = new Thickness(a, b, 0, 0);

                    break;
            }
        }
    }
}
