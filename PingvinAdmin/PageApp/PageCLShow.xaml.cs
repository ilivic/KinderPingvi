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
using static PingvinAdmin.PageApp.PageWorkerShow;

namespace PingvinAdmin.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageCLShow.xaml
    /// </summary>
    public partial class PageCLShow : Page
    {
        public class CountUser
        {
            public string UserName { get; set; }
            public int CountDisk { get; set; }
            public int CountAll { get; set; }
        }

        public static List<CountUser> CountUserOrder { get; set; }
        public PageCLShow()
        {
            InitializeComponent();
            CountUserOrder = new List<CountUser>();
            foreach (var Index in App.Connection.Users.Where(z => z.Role_id == 3).ToList())
            {
                CountUser NewUserCounter = new CountUser();
                NewUserCounter.UserName = Index.Name;
                int Counter = 0;
                foreach (var IndexCount in App.Connection.Orders.Where(z => z.User_id_Client == Index.Id_User).ToList())
                {
                    Counter++;
                }
                NewUserCounter.CountAll = Counter;
                NewUserCounter.CountDisk = Index.DiskS.Count;
                CountUserOrder.Add(NewUserCounter);
            }
            ListUser.ItemsSource = CountUserOrder.ToList();

        }
    }
    
}
