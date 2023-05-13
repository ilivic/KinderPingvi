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
    /// Логика взаимодействия для PageNewOrder.xaml
    /// </summary>
    public partial class PageNewOrder : Page
    {
        public PageNewOrder()
        {
            InitializeComponent();
        }

        private void ClickAddNewOrder(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtTitle.Text != "")
                {
                    Orders NewOrder = new Orders()
                    {
                        TypeOrder_id = 1,
                        User_id_Client = CorrUserClass.CorrUser.Id_User,
                        Price_id = 0,
                        Title = TxtTitle.Text
                    };
                    App.Connection.Orders.Add(NewOrder);
                    App.Connection.SaveChanges();
                    MessageBox.Show("Вы были записаны \n Свободный мастер скоро рассмотрит вашу заявку","Успешно",MessageBoxButton.OK,MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClickGoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
