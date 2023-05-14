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

namespace PingvinMaster.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAllTask.xaml
    /// </summary>
    public partial class PageAllTask : Page
    {   
        /// <summary>
        /// публичный лист с информацией о всех заявках
        /// </summary>
        public static List<Orders> ListOrd { get; set; }
        /// <summary>
        /// метод инициализации и заполнения данными о заявках
        /// </summary>
        public PageAllTask()
        {
            InitializeComponent();
            ListOrd = new List<Orders>(App.Connection.Orders.Where(z => z.Users1 == null).ToList());
            ListOrder.ItemsSource = ListOrd;
        }
        /// <summary>
        /// метод прикрепления заявки к авторизовавшемуся мастеру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventSelectOrder(object sender, SelectionChangedEventArgs e)
        {
            if (ListOrder.SelectedItem != null)
            {
                var selectTask = ListOrder.SelectedItem as Orders;
                if (MessageBox.Show("Взять на себя выбранную заявку?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    selectTask.User_id_Worker = CorrUserClass.CorrUser.Id_User;
                    App.Connection.SaveChanges();
                    MessageBox.Show("Заявка успешно записанна на вас \n Ебитесь))", "Информация", MessageBoxButton.YesNo, MessageBoxImage.Information);
                }
            }
        }
    }
}
