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

        private void ClicklShowService(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageProdShow());
        }

        private void ClickShowItem(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageServiceShow());
        }

        private void ClickShowOrder(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageOrderShow());
        }

        private void ClickShowWorker(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageWorkerShow());
        }

        private void ClickShowShowCL(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageCLShow());
        }

        private void ClickAddWorker(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddNewWorker());
        }

        private void ClickAddUser(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddCl());
        }

        private void ClickAddManager(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddManager());
        }
    }
}
