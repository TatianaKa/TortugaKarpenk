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
using TortugasKarpenko.Windows;
using TortugasKarpenko.Pages;

namespace TortugasKarpenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int Number;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnTableOne_Click(object sender, RoutedEventArgs e)
        {
            Number = 1;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }


        private void txbExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnTableTwo_Click(object sender, RoutedEventArgs e)
        {
            Number = 2;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableThree_Click(object sender, RoutedEventArgs e)
        
        {
            Number = 3;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableFo_Click(object sender, RoutedEventArgs e)
        {
            Number = 4;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableFive_Click(object sender, RoutedEventArgs e)
        {
            Number = 5;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableSix_Click(object sender, RoutedEventArgs e)
        {
            Number = 6;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }
        private void btnTableSeven_Click(object sender, RoutedEventArgs e)
        {
            Number = 7;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableEight_Click(object sender, RoutedEventArgs e)
        {
            Number = 8;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableNine_Click(object sender, RoutedEventArgs e)
        {
            Number = 9;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableTen_Click(object sender, RoutedEventArgs e)
        {
            Number = 10;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableEleven_Click(object sender, RoutedEventArgs e)
        {
            Number = 11;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        private void btnTableTwelf_Click(object sender, RoutedEventArgs e)
        {
            Number = 12;
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
            Close();
        }

        
    }
}
