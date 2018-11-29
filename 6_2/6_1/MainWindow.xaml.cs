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
using System.Text.RegularExpressions;
using System.Windows.Media.Animation;

namespace _6_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_All_Click(object sender, RoutedEventArgs e)
        {
            string allText = TB_All.Text;
            int[] rexes=new int[7];
            string[] charss = { "A","B","C","D","E","F","G" };
            for(int i = 0; i < 7; i++)
            {
                rexes[i] = Regex.Matches(allText, charss[i]).Count;
            }
            
            
            Rectangle[] rectangle = new Rectangle[7];
            int[] ma = { 100,0,0,100};
            int[] mb = { 100, 0, 0, 100 };

            int[] mc = { 100, 0, 0, 100 };
            TextBlock[] textBlocks = new TextBlock[7];
            TextBlock[] textBlocks1 = new TextBlock[7];
            for(int i = 0; i < 7; i++)
            {
                textBlocks[i] = new TextBlock();
                textBlocks[i].Text = charss[i];
                textBlocks[i].VerticalAlignment = VerticalAlignment.Bottom;
                textBlocks[i].HorizontalAlignment = HorizontalAlignment.Left;
                textBlocks[i].Margin = new Thickness(mb[0] += 50, mb[1], mb[2], mb[3]-30);
                GridMain.Children.Add(textBlocks[i]);

                textBlocks1[i] = new TextBlock();
                textBlocks1[i].Text = rexes[i].ToString();
                textBlocks1[i].VerticalAlignment = VerticalAlignment.Bottom;
                textBlocks1[i].HorizontalAlignment = HorizontalAlignment.Left;
                textBlocks1[i].Margin = new Thickness(mc[0] += 50, mc[1], mc[2], mc[3] - 40);
                GridMain.Children.Add(textBlocks1[i]);

                rectangle[i] = new Rectangle();
                rectangle[i].VerticalAlignment = VerticalAlignment.Bottom;
                rectangle[i].HorizontalAlignment = HorizontalAlignment.Left;
                rectangle[i].Width = 10;
                rectangle[i].Height = 0;
                rectangle[i].Margin = new Thickness(ma[0]+=50, ma[1], ma[2], ma[3]);
                rectangle[i].Fill =new SolidColorBrush(Color.FromRgb(0, 155, 155));
                GridMain.Children.Add(rectangle[i]);
            }

           // DoubleAnimation doubleAnimation = new DoubleAnimation();
            for(int i = 0; i < 7; i++)
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = rectangle[i].Height;
                doubleAnimation.To = rexes[i] * 30;
                doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
                rectangle[i].BeginAnimation(Rectangle.HeightProperty, doubleAnimation);
            }

        }
    }
}
