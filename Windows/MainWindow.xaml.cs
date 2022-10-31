using System;
using System.Windows;
using System.Windows.Input;
using TortugasKarpenko.Windows;

namespace TortugasKarpenko
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number;
        public static int orderId { get; set; }
        private void CreateOrder()
        {
            try
            {
                EF.Order order = new EF.Order();
                order.TableId = number;
                order.DateOrder = DateTime.Now;
                ClassHelper.AppData.context.Order.Add(order);
                ClassHelper.AppData.context.SaveChanges();
                orderId = order.Id;
                Pages.OrderPage.orderDish.Order = order;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnTableOne_Click(object sender, RoutedEventArgs e)
        {
            number = 1;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }


        private void txbExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnTableTwo_Click(object sender, RoutedEventArgs e)
        {
            number = 2;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableThree_Click(object sender, RoutedEventArgs e)

        {
            number = 3;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableFo_Click(object sender, RoutedEventArgs e)
        {
            number = 4;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableFive_Click(object sender, RoutedEventArgs e)
        {
            number = 5;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableSix_Click(object sender, RoutedEventArgs e)
        {
            number = 6;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }
        private void btnTableSeven_Click(object sender, RoutedEventArgs e)
        {
            number = 7;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableEight_Click(object sender, RoutedEventArgs e)
        {
            number = 8;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableNine_Click(object sender, RoutedEventArgs e)
        {
            number = 9;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableTen_Click(object sender, RoutedEventArgs e)
        {
            number = 10;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableEleven_Click(object sender, RoutedEventArgs e)
        {
            number = 11;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }

        private void btnTableTwelf_Click(object sender, RoutedEventArgs e)
        {
            number = 12;
            MenuWindow menuWindow = new MenuWindow();
            CreateOrder();
            menuWindow.Show();
            Close();
        }


    }
}
