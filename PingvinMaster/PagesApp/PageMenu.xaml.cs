using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PingvinMaster.PagesApp
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

        private void ClickShowAllTask(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAllTask());
        }

        private void ClikcInputInfo(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", @"/k index.html && exit");
        }

        private void ClickMyTask(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageMyTask());
        }

        private void ClickRefresh(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageDefault());
        }

        private void ClickShowAllKL(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageShowAllCl());
        }
    }
}
