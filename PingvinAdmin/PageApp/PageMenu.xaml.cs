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
using PingvinAdmin.PageApp;

namespace PingvinAdmin.PageApp
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageProdShow());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageServiceShow());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageOrderShow());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageWorkerShow());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageCLShow());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddNewWorker());
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddCl());
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddManager());
        }
    }
}
