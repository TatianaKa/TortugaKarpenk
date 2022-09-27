using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TortugasKarpenko.Pages;

namespace TortugasKarpenko.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            LVCatalog.ItemsSource = ClassHelper.AppData.context.Category.ToList();


        }

        private void txbBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
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
    }
}
