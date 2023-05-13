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

namespace PingvinAdmin.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageWorkerShow.xaml
    /// </summary>
    public partial class PageWorkerShow : Page
    {
        public class UserCount
        {
            public string Name {get;set;}
            public int Count { get; set; }
        }

        public static List<UserCount> CountUserOrder { get; set; }
        public PageWorkerShow()
        {
            InitializeComponent();
            CountUserOrder = new List<UserCount>();
            foreach (var Index in App.Connection.Users.Where(z => z.Role_id == 2).ToList())
            {
                UserCount NewUserCounter = new UserCount();
                NewUserCounter.Name = Index.Name;
                int Counter = 0;
                foreach (var IndexCount in App.Connection.Orders.Where(z => z.User_id_Worker == Index.Id_User).ToList())
                {
                    Counter++;
                }
                NewUserCounter.Count = Counter;
                CountUserOrder.Add(NewUserCounter);
            }
            ListUser.ItemsSource = CountUserOrder.ToList();
        }
    }
}
