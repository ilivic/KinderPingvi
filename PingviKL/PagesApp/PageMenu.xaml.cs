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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PingviKL.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void ClickExit(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ClickCreateNewOrder(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PageNewOrder());
        }

        private void ClickByItem(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new PageByProd());
        }

        private void ClickShowInfo(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Попрежнему Нихуя не понятно","Информация",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
