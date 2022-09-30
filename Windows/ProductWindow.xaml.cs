using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace TortugasKarpenko.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        int Cost;
        public static int DishId;
        public static int OrderId;
        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(int IdDish)
        {
            InitializeComponent();
            DishId = IdDish;
            Cost = Convert.ToInt32(ClassHelper.AppData.context.Dish.Where(i => i.Id == IdDish).FirstOrDefault().Cost);
            LvProduct.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.Id == IdDish).ToList();

        }

        private void txbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Close();
        }

        private void txbAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EF.OrderDish orderDish = new EF.OrderDish();
            orderDish.DishId = DishId;
            orderDish.OrderId = MenuWindow.OrderId;
            orderDish.Qty = 1;
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
