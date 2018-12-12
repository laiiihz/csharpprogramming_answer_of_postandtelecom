using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _7_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public class Fxxxk : INotifyPropertyChanged
        {
            public int MaxNum { get; set; }
            public int AveNum { get; set; }
            public int MinNum { get; set; }
            public event PropertyChangedEventHandler PropertyChanged;
        }
        

        public MainWindow()
        {
            InitializeComponent();
        }
        Fxxxk fxxxk = new Fxxxk();
        private void BtnGen_Click(object sender, RoutedEventArgs e)
        {
            int[] a = new int[20];
            int all = 0;
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                fk.Text = null;
                int genNum=random.Next(500);
                a[i] = genNum;
                all += a[i];
            }
            for (int i = 0; i < 20; i++)
            {
                fk.Text += a[i].ToString() + " ";
            }


                Array.Sort(a);

            
            fxxxk.MaxNum = a[19];
            fxxxk.MinNum = a[0];
            fxxxk.AveNum = all / 20;

            minText.SetBinding(TextBox.TextProperty, new Binding()
            {
                Source = fxxxk,
                Path = new PropertyPath("MinNum")
            });

            avgText.SetBinding(TextBox.TextProperty, new Binding()
            {
                Source = fxxxk,
                Path = new PropertyPath("AveNum")
            });
            
            maxText.SetBinding(TextBox.TextProperty, new Binding()
            {
                Source = fxxxk,
                Path = new PropertyPath("MaxNum")
            });




        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
