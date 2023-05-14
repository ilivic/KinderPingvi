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

namespace PingvinMaster.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageShowAllCl.xaml
    /// </summary>
    public partial class PageShowAllCl : Page
    {
        /// <summary>
        /// метод иниализаций и заполениния информаций о скидке и клинте
        /// </summary>
        public PageShowAllCl()
        {
            InitializeComponent();
            ListUser.ItemsSource = App.Connection.DiskS.Where(z => z.Users.Role_id == 3).ToList();
        }
    }
}
