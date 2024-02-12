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

namespace Play
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void Game(object sender, RoutedEventArgs e)
        {
            if(u1v1.IsChecked == true && u2v1.IsChecked == true)
            {
                result.Content = "Ничья";
            }
            if (u1v1.IsChecked == true && u2v2.IsChecked == true)
            {
                result.Content = $"Победил {User.UserFirst}!";
            }
            if (u1v1.IsChecked == true && u2v3.IsChecked == true)
            {
                result.Content = $"Победил {User.UserSecond}!";
            }

            if (u1v2.IsChecked == true && u2v1.IsChecked == true)
            {
                result.Content = $"Победил {User.UserSecond}!";
            }
            if (u1v2.IsChecked == true && u2v2.IsChecked == true)
            {
                result.Content = "Ничья!";
            }
            if (u1v2.IsChecked == true && u2v3.IsChecked == true)
            {
                result.Content = $"Победил {User.UserFirst}!";
            }
            if (u1v3.IsChecked == true && u2v1.IsChecked == true)
            {
                result.Content = $"Победил {User.UserFirst}!";
            }
            if (u1v3.IsChecked == true && u2v2.IsChecked == true)
            {
                result.Content = $"Победил {User.UserSecond}!";
            }
            if (u1v3.IsChecked == true && u2v3.IsChecked == true)
            {
                result.Content = $"Ничья!";
            }
            u1v1.IsChecked = false;
            u1v2.IsChecked = false;
            u1v3.IsChecked = false;
            u2v1.IsChecked = false;
            u2v2.IsChecked = false;
            u2v3.IsChecked = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            result.Content = "";
        }

    }
}
