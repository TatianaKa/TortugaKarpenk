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

namespace TortugasKarpenko.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }
        public ProductWindow(int IdDish)
        {
            InitializeComponent();
            LvProduct.ItemsSource = ClassHelper.AppData.context.Dish.Where(i => i.Id == IdDish).ToList();
        }

        private void txbClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            Close();
        }

        private void txbAdd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EF.Order order= new EF.Order();
            order.TableId = MainWindow.Number;
            MessageBox.Show("Товар добавлен");
        }

      
    }
}
