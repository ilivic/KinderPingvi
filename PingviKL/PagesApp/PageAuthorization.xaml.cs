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
using PingviKL.ClassApp;

namespace PingviKL.PagesApp
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var DataUser = App.Connection.Users.Where(z => z.Code.ToString() == TxtCode.Text).FirstOrDefault();
                if (DataUser != null)
                {
                    if (DataUser.Role_id == 3)
                    {
                        CorrUserClass.CorrUser = DataUser;
                        NavigationService.Navigate(new PageMenu());

                    }
                    else
                    {
                        MessageBox.Show("тебе сюда нельзя", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя не существует", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
