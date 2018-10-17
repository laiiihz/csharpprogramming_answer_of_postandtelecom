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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SourceInitialized += MainWindow_SI;
            
        }

        private void MainWindow_SI(object sender, EventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb_1.Text = "laihz";
            tb_2.Text = "fffffffffff";
            tb_3.Text = "qqqqqqqqqq";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string getWordsa = tb_1.Text + "%%" + tb_2.Text + "%%" + tb_3.Text;
            DialogWindow dialogWindow = new DialogWindow();
            dialogWindow.GetWords = getWordsa;
            dialogWindow.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tb_1.Text + "%%" + tb_2.Text + "%%" + tb_3.Text);
        }
    }
}
