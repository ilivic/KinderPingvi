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
using PingviKL.ADOApp;
using PingviKL.ClassApp;

namespace PingviKL.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageByProd.xaml
    /// </summary>
    public partial class PageByProd : Page
    {
        public PageByProd()
        {
            InitializeComponent();
            ListProd.ItemsSource = App.Connection.Items.ToList();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ListProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListProd.SelectedItem != null)
            {
                var ByItem = (Items)ListProd.SelectedItem;
                if (MessageBox.Show($"вы уверенны, что хотите купить {ByItem.Title} за {ByItem.Price}?", "вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        int SummOrder = ByItem.Price;
                        var Disks = App.Connection.DiskS.Where(z => z.User_id == CorrUserClass.CorrUser.Id_User).FirstOrDefault();
                        if (Disks != null)
                        {
                            switch (Disks.countOrder)
                            {
                                case 10:
                                    {
                                        Disks.countOrder++;
                                        SummOrder -= (SummOrder / 100) * 10;
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
                                User_id = CorrUserClass.CorrUser.Id_User,
                            };
                            App.Connection.DiskS.Add(NewDis);
                        }
                        App.Connection.SaveChanges();
                        MessageBox.Show($"покупка на {SummOrder} выполнена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }    
            }
        }
    }
}
