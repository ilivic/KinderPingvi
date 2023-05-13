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

namespace KinderPingui.PagesApp
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

        private void ClickAnotherInfomation(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("что-то на пингвинском \n Нихуя не понятно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClickAddNewItemOrService(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageAddItemsOrService());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainNavigationFrame.NavigationService.Navigate(new PageShowInemsAndService());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("cmd.exe", @"/k index.html && exit"); 
        }
    }
}
