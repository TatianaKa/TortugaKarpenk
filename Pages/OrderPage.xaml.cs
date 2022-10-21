using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TortugasKarpenko.Windows;

namespace TortugasKarpenko.Pages
{
    public partial class OrderPage : Page
    {
        public static EF.OrderDish orderDish = new EF.OrderDish();
        bool pay = false;
        int qty;
        decimal cost, finishCost;
        List<EF.OrderDish> list = new List<EF.OrderDish>();
        private void CountFinishCost()
        {
            list = ClassHelper.AppData.context.OrderDish.ToList();
            for (int i = 1; i < list.Count; i++)
            {
                if (MainWindow.orderId == i)
                {
                    finishCost += cost;
                }
            }
            MessageBox.Show(finishCost.ToString());
        }
        public OrderPage()
        {
            InitializeComponent();
            Filter();
        }
        public OrderPage(EF.OrderDish OrderDish)
        {
            InitializeComponent();
            pay = true;
            Filter();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            if (pay == false)
            {
                MessageBox.Show("Блюда не выбраны");
                return;
            }
            else
            {
                PayWindow pay = new PayWindow();
                pay.ShowDialog();
            }

        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Content = null;
        }

        private void txbDelete_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (orderDish.Id != null)
            {
                var mes = MessageBox.Show("Вы уверены?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (mes == MessageBoxResult.Yes)
                {
                    ClassHelper.AppData.context.OrderDish.Remove(orderDish);
                    ClassHelper.AppData.context.SaveChanges();
                    MessageBox.Show("Удалено");
                }
            }
        }
        public void Filter()
        {
            LvOrder.ItemsSource = ClassHelper.AppData.context.OrderDish.Where(i => i.OrderId == MainWindow.orderId).ToList();
        }
        private void LvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var orderdish = LvOrder.SelectedItem as EF.OrderDish;
            orderDish = orderdish;
            if (orderdish != null)
            {
                qty = orderdish.Qty;
                cost = ClassHelper.AppData.context.Dish.Where(i => i.Id == orderDish.DishId).First().Cost;
            }

            Filter();

        }

        private void txbMinus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (qty == 1)
            {

            }
            else if (qty == 0)
            {
                qty += 1;
                orderDish.Qty = qty;
                orderDish.Cost = cost * qty;
                ClassHelper.AppData.context.SaveChanges();
            }
            else
            {
                qty -= 1;
                orderDish.Qty = qty;
                orderDish.Cost = cost * qty;
                ClassHelper.AppData.context.SaveChanges();
            }
            Filter();
        }

        private void txbPlus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            qty += 1;
            orderDish.Qty = qty;
            orderDish.Cost = cost * qty;
            ClassHelper.AppData.context.SaveChanges();
            CountFinishCost();
            Filter();
        }

    }
}
