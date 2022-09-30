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
    /// Логика взаимодействия для PayWindow.xaml
    /// </summary>
    public partial class PayWindow : Window
    {
        public PayWindow()
        {
            InitializeComponent();
        }

        private void btnExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            if (chbCard.IsChecked == true && chbNal.IsChecked == true)
            {
                MessageBox.Show("Нельзя выбрать сразу два пункта");
               
            }
            else if (chbCard.IsChecked == true || chbNal.IsChecked == true)
            {
                MessageBox.Show("Оплата успешно прошла");
                MenuWindow menu = new MenuWindow();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите способ оплаты");
            }
           
        }
    }
}
