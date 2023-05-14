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
using KinderPingui.ADOApp;
using KinderPingui.ClassApp;

namespace KinderPingui.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageShowInemsAndService.xaml
    /// </summary>
    public partial class PageShowInemsAndService : Page
    {
        public static List<CostTAbletClass> ListAllInfo { get; set; }
        public PageShowInemsAndService()
        {
            InitializeComponent();
            ListAllInfo = new List<CostTAbletClass>();
            DataInsert();
            ListPriceAndItems.ItemsSource = ListAllInfo;
        }
        public void DataInsert()
        {
            foreach (var Index in App.Connection.Items.ToList())
            {
                CostTAbletClass NewIndex = new CostTAbletClass()
                {
                    Photo = Index.Photo,
                    Title = Index.Title,
                    Price = Index.Price,
                };
                ListAllInfo.Add(NewIndex);
            }
            foreach (var Index in App.Connection.PriceList.ToList())
            {
                CostTAbletClass NewIndex = new CostTAbletClass()
                {
                    Photo = Index.Photo,
                    Title = Index.Title,
                    Price = Index.Price,
                };
                ListAllInfo.Add(NewIndex);
            }
        }

        private void TextSerchPress(object sender, TextChangedEventArgs e)
        {
           ListPriceAndItems.ItemsSource = ListAllInfo.Where(z=> z.Title.Contains(TxtSerch.Text));
        }

        private void ClickOrderBy(object sender, RoutedEventArgs e)
        {
            ListPriceAndItems.ItemsSource = ListAllInfo.OrderBy(z => z.Price);
        }

        private void ClickOrderByDisk(object sender, RoutedEventArgs e)
        {
            ListPriceAndItems.ItemsSource = ListAllInfo.OrderByDescending(z => z.Price);
        }

        private void EventFilter(object sender, SelectionChangedEventArgs e)
        {
            switch (CMB.SelectedIndex)
            {
                case 1:
                    {
                        ListPriceAndItems.ItemsSource = null;
                        ListPriceAndItems.ItemsSource = App.Connection.PriceList.ToList();
                        break;
                    }
                case 0:
                    {
                        ListPriceAndItems.ItemsSource = null;
                        ListPriceAndItems.ItemsSource = App.Connection.Items.ToList();
                        break;
                    }
                case 2:
                    {
                        ListAllInfo.Clear();
                        DataInsert();
                        ListPriceAndItems.ItemsSource = null;
                        ListPriceAndItems.ItemsSource = ListAllInfo;
                        break;
                    }
            }
        }
    }
}
