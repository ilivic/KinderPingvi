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
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClicklShowService(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageProdShow());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickShowItem(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageServiceShow());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickShowOrder(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageOrderShow());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickShowWorker(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageWorkerShow());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickShowShowCL(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageCLShow());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddWorker(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddNewWorker());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddUser(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddCl());
        }
        /// <summary>
        /// метод навигации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAddManager(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddManager());
        }
    }
}
