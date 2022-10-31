using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TortugasKarpenko.Pages;

namespace TortugasKarpenko.Windows
{
    public partial class MenuWindow : Window
    {
        private List<EF.Dish> dishes = new List<EF.Dish>();
        public MenuWindow()
        {
            InitializeComponent();
            LVCatalog.ItemsSource = ClassHelper.AppData.context.Category.ToList();
            LVItems.ItemsSource = ClassHelper.AppData.context.Dish.ToList();
        }

        private void txbBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void txbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void txbOrder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new OrderPage());
        }

        private void LVCatalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Category = LVCatalog.SelectedItem as EF.Category;
            LVItems.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.CategoryId == Category.Id).ToList();
        }

        private void LVItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Dish = LVItems.SelectedItem as EF.Dish;
            if (Dish != null)
            {
                ProductWindow product = new ProductWindow(Dish.Id);
                this.Opacity = 50;
                product.Show();
            }

        }

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    var button = sender as Button;
        //    if (button != null)
        //        return;
        //    var dish=button.DataContext as EF.Dish;
        //    dishes.Add(dish);
        //}
    }
}
