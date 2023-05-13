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
using PingvinMaster.ADOApp;

namespace PingvinMaster.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для WindowChTask.xaml
    /// </summary>
    public partial class WindowChTask : Window
    {
        public static Orders SelOrder { get; set; }
        public WindowChTask(Orders SelectOrder)
        {
            InitializeComponent();
            SelOrder = SelectOrder;
            CmbNewItem.ItemsSource = App.Connection.Items.ToList();
            CMBNewItemType.ItemsSource = App.Connection.TypeItems.ToList();
            CMBNewOrder.ItemsSource = App.Connection.PriceList.ToList();
        }

        private void ClickAdditems(object sender, RoutedEventArgs e)
        {
            try
            {
                 var SelectedItem = (Items)CmbNewItem.SelectedItem;
                var TypeItem = (TypeItems)CMBNewItemType.SelectedItem;
                ItemOrder NewItemOrder = new ItemOrder()
                {
                 
                    Items = SelectedItem,
                    Orders = SelOrder,
                    Date = DateTime.Now,
                    TypeItems = TypeItem

                };
                App.Connection.ItemOrder.Add(NewItemOrder);
                App.Connection.SaveChanges();
                MessageBox.Show("Добавление товара к услуге прошло успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickAddPrice(object sender, RoutedEventArgs e)
        {
            try
            {
                var Selected = (PriceList)CMBNewOrder.SelectedItem;
                PriceListOrder NewItemOrder = new PriceListOrder()
                {
                    PriceList = Selected,
                    Orders = SelOrder,
                    Date = DateTime.Now,

                };
                App.Connection.PriceListOrder.Add(NewItemOrder);
                App.Connection.SaveChanges();
                MessageBox.Show("Добавление услуги к заказу прошло успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
