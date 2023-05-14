﻿using System;
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
    /// Логика взаимодействия для PageProdShow.xaml
    /// </summary>
    public partial class PageProdShow : Page
    {/// <summary>
     /// метод инициализации и вывода списка оказанных услуг  
     /// </summary>
        public PageProdShow()
        {
            InitializeComponent();
            ListProd.ItemsSource = App.Connection.PriceListOrder.ToList();
        }
    }
}
