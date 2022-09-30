using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TortugasKarpenko.Windows;

namespace TortugasKarpenko.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        int OrderDishId, Cost, Qty;
        public OrderPage()
        {
            InitializeComponent();
            Filter();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {

            PayWindow pay = new PayWindow();
            pay.ShowDialog();
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Content = null;
        }

        private void txbDelete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (OrderDishId != null)
            {
                var mes = MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mes == MessageBoxResult.Yes)
                {
                    //ClassHelper.AppData.context.OrderDish.Remove(orderDish);
                    //ClassHelper.AppData.context.SaveChanges();
                    //MessageBox.Show("Удалено");
                }


            }
            else
            {
                MessageBox.Show("Не ура");
            }
        }
        public void Filter()
        {
            LvOrder.ItemsSource = ClassHelper.AppData.context.OrderDish.Where(i => i.OrderId == MenuWindow.OrderId).ToList();
        }
        private void LvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var OrderDish = LvOrder.SelectedItem as EF.OrderDish;
            OrderDishId = OrderDish.Id;
            Cost = Convert.ToInt32(ClassHelper.AppData.context.Dish.Where(i => i.Id == OrderDish.DishId).FirstOrDefault().Cost);
            Qty = OrderDish.Qty;
            Filter();
        }

        private void txbMinus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Qty == 1)
            {

            }
            else
            {
                ClassHelper.AppData.context.OrderDish.Where(i => i.Id == OrderDishId).FirstOrDefault().Qty = Qty - 1;
                ClassHelper.AppData.context.SaveChanges();
            }
            Filter();
        }

        private void txbPlus_MouseDown(object sender, MouseButtonEventArgs e)
        {

            ClassHelper.AppData.context.OrderDish.Where(i => i.Id == OrderDishId).FirstOrDefault().Qty = Qty + 1;
            ClassHelper.AppData.context.SaveChanges();

            Filter();
        }
    }
}
