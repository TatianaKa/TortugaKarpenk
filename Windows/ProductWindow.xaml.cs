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
        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(int IdDish)
        {
            InitializeComponent();
            dishId = IdDish;
            LvProduct.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.Id == IdDish).ToList();

        }
        private void txbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void txbAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            decimal cost = ClassHelper.AppData.context.Dish.Where(i => i.Id == dishId).First().Cost;
            EF.OrderDish orderDish = new EF.OrderDish();
            orderDish.DishId = dishId;
            orderDish.OrderId = MainWindow.orderId;
            orderDish.Qty = 1;
            orderDish.Cost = cost;
            OrderPage orderPage = new OrderPage(orderDish);
            ClassHelper.AppData.context.OrderDish.Add(orderDish);
            ClassHelper.AppData.context.SaveChanges();
            var mes = MessageBox.Show("Товар добавлен");
            if (mes == MessageBoxResult.OK)
            {
                this.Close();
            }
        }


    }
}
