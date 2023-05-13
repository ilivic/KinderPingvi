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
using PingvinMaster.ADOApp;
using PingvinMaster.ClassApp;
using PingvinMaster.WindowsApp;

namespace PingvinMaster.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageMyTask.xaml
    /// </summary>
    public partial class PageMyTask : Page
    {
        public static List<Orders> ListOrd { get; set; }
        public PageMyTask()
        {
            InitializeComponent();
            ListOrd = new List<Orders>(App.Connection.Orders.Where(z => z.User_id_Worker == CorrUserClass.CorrUser.Id_User && z.Price_id == 0).ToList());
            ListOrder.ItemsSource = ListOrd;
        }

        private void ClickChOrder(object sender, RoutedEventArgs e)
        {
            if (ListOrder.SelectedItem != null)
            {
                var SelectOrder = (Orders)ListOrder.SelectedItem;
                WindowChTask window = new WindowChTask(SelectOrder);
                window.Show();
            }
            
        }

        private void ClickCloseOrder(object sender, RoutedEventArgs e)
        {
            try
            {
                int SummOrder = 0;
                var SelectOrder = (Orders)ListOrder.SelectedItem;
                foreach (var Index in App.Connection.PriceListOrder.Where(z => z.Order_id == SelectOrder.id_order).ToList())
                {
                    SummOrder += Index.PriceList.Price;
                }
                foreach (var Index in App.Connection.ItemOrder.Where(z => z.Order_id == SelectOrder.id_order).ToList())
                {
                    SummOrder += Index.Items.Price;
                }
                var CloseOrder = App.Connection.Orders.Where(z => z.id_order == SelectOrder.id_order).First();
               
                var Disks = App.Connection.DiskS.Where(z => z.User_id == SelectOrder.User_id_Client).FirstOrDefault();
                if (Disks != null)
                {
                    switch (Disks.countOrder)
                    {
                        case 10:
                            {
                                Disks.countOrder++;
                                SummOrder -= (SummOrder / 100)*10;
                                break;
                            }
                        case 20:
                            {
                                Disks.countOrder++;
                                SummOrder -= (SummOrder / 100) * 20;
                                break;
                            }
                        case 30:
                            {
                                Disks.countOrder++;
                                SummOrder -= (SummOrder / 100) * 30;
                                break;
                            }
                        case 40:
                            {
                                Disks.countOrder++;
                                SummOrder -= (SummOrder / 100) * 40;
                                break;
                            }
                        case 50:
                            {
                                Disks.countOrder -= Disks.countOrder;
                                SummOrder -= (SummOrder / 100) * 50;
                                break;
                            }
                            default:
                            {
                                Disks.countOrder++;
                                break;
                            }
                    }
                   

                }
                else
                {
                    DiskS NewDis = new DiskS()
                    {
                        countOrder = 0,
                        Title = "Default",
                        User_id = SelectOrder.User_id_Client,
                    };
                    App.Connection.DiskS.Add(NewDis);
                }
                CloseOrder.Price_id = SummOrder;
                App.Connection.SaveChanges();
                MessageBox.Show($"Заказ на {SummOrder} закрыт", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
