using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp5_3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private int counter = 25;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_gen_Click(object sender, RoutedEventArgs e)
        {
            counter = 25;
            int dateTime = (int)(DateTime.Now.Ticks%10000);         
            Random random = new Random(dateTime);
            qust1.Text = random.Next(0, 101).ToString();
            qust11.Text = random.Next(0, 101).ToString();
            qust2.Text = random.Next(0, 101).ToString();
            qust3.Text = random.Next(0, 11).ToString();
            qust4.Text = random.Next(0, 11).ToString();
            qust22.Text = random.Next(0, 101).ToString();
            qust33.Text = random.Next(0, 11).ToString();
            qust44.Text = random.Next(0, 11).ToString();
            dispatcherTimer.Interval = new TimeSpan(10000000);
            dispatcherTimer.Tick += new EventHandler(changeText);
            dispatcherTimer.Start();
        }

        private void changeText(object sender, EventArgs e)
        {
            
            label_head.Content = "剩余时间：" + counter;
            counter--;
            if (counter == 0)
            {
                MessageBox.Show("过关失败，请继续努力");
                dispatcherTimer.Stop();
                
            }
        }

   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            if( int.Parse(qust1.Text) + int.Parse(qust11.Text) == int.Parse(as1.Text) &&
                int.Parse(qust2.Text) - int.Parse(qust22.Text) == int.Parse(as2.Text) &&
                int.Parse(qust3.Text) * int.Parse(qust33.Text) == int.Parse(as3.Text) &&
                int.Parse(qust4.Text) / int.Parse(qust44.Text) == int.Parse(as4.Text)
                )
            {
                MessageBox.Show("恭喜过关成功");
            }
        }
    }
}
