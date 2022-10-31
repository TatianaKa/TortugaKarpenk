using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TortugasKarpenko.Pages;

namespace TortugasKarpenko.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public static int dishId;

        public static List<EF.OrderDish> orderdishesList = new List<EF.OrderDish>();

        decimal cost;
        int qty;
        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(int IdDish)
        {
            InitializeComponent();
            dishId = IdDish;
            cost = ClassHelper.AppData.context.Dish.Where(i => i.Id == dishId).First().Cost;
            LvProduct.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.Id == IdDish).ToList();

        }
        private void txbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void txbAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            bool isEdit = false;
            for (int i = 0; i < orderdishesList.Count; i++)
            {
                if (orderdishesList[i].DishId == dishId)
                {
                    EF.OrderDish dish = orderdishesList[i];
                    qty = orderdishesList[i].Qty;
                    dish.DishId = dishId;
                    dish.OrderId = MainWindow.orderId;
                    qty += 1;
                    dish.Qty = qty;
                    dish.Cost = cost * qty;
                    OrderPage.finishCost += (decimal)dish.Cost;
                    OrderPage.pay = true;
                    ClassHelper.AppData.context.SaveChanges();
                    var mes = MessageBox.Show("Блюдо изменено");
                    if (mes == MessageBoxResult.OK)
                    {
                        isEdit = true;
                        this.Close();
                    }

                }
                //else
                //{
                //    AddOrderDish();

                //}
            }
            if (isEdit == true)
            {

            }
            else
            {
                AddOrderDish();
            }

        }
        private void AddOrderDish()
        {
            EF.OrderDish orderDish = new EF.OrderDish();
            orderDish.DishId = dishId;
            orderDish.OrderId = MainWindow.orderId;
            orderDish.Qty = 1;
            orderDish.Cost = cost;
            OrderPage.finishCost += cost;
            OrderPage.pay = true;
            ///ClassHelper.AppData.context.Dish.Where(i => i.Id == dishId).First().Title
            ClassHelper.AppData.context.OrderDish.Add(orderDish);
            ClassHelper.AppData.context.SaveChanges();
            orderdishesList.Add(orderDish);
            var mes = MessageBox.Show("Блюдо добавлено");
            if (mes == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

    }
}
