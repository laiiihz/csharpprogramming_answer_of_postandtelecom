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

namespace WpfApp5_1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        int login_time = 1;
        public Window1()
        {
            InitializeComponent();
            Dictionary<int, String> dic = new Dictionary<int, string>()
            {
                {1,"管理员" },
                {2,"一般用户" }
            };
            combobox1.ItemsSource = dic;
            combobox1.SelectedValuePath = "Key";
            combobox1.DisplayMemberPath = "Value";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           

            if (text_pwd.Password == "123abc"|| text_pwd.Password == "abcabc")
            {
                this.Hide();
            }
            else if (login_time == 3)
            {
                Application.Current.Shutdown();
            }
            else
            {
                login_time++;
                image_war.Visibility =Visibility.Visible;
            }
        }

        private void Text_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_pwd_PasswordChanged(object sender, RoutedEventArgs e)
        {
            image_war.Visibility = Visibility.Hidden;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            //Application.Current.Shutdown();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
