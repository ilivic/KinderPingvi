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
using KinderPingui.ClassApp;

namespace KinderPingui.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAuthorization.xaml
    /// </summary>
    public partial class PageAuthorization : Page
    {
        public PageAuthorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод Авторизации получаемое значение запись пользователя в базе данных передаётся в класс "CorrUser" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAuthorization(object sender, RoutedEventArgs e)
        {
            var DataUser = App.Connection.Users.Where(z=>z.Code.ToString() == TxtCode.Text).FirstOrDefault();
            if (DataUser != null)
            {
                if (DataUser.Role_id == 1)
                {
                    CorrUserClass.CorrUser = DataUser;
                    NavigationService.Navigate(new PageMenu());
                }
                else 
                {
                    MessageBox.Show("Плавником по ебалу не хочешь?! тебе сюда НеЗя", "Код Красный", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Тебя нет в системе","Код Красный", MessageBoxButton.OK, MessageBoxImage.Information);   
            }
        }
    }
}
