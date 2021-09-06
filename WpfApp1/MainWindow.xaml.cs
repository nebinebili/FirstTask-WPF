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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {

                var random = new Random();

                var r = Convert.ToByte(random.Next(0, 255));
                var g = Convert.ToByte(random.Next(0, 255));
                var b = Convert.ToByte(random.Next(0, 255));

                btn.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

                MessageBox.Show($"Button{btn.Content} Clicked", "Caption", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btn1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(sender is Button btn)
            {
                Grid1.Children.Remove(btn);
                Window.Title = $"{btn.Content}";
            }
            
        }
    }
}
