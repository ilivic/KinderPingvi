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
using PingvinAdmin.ADOApp;

namespace PingvinAdmin.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageAddCl.xaml
    /// </summary>
    public partial class PageAddCl : Page
    {
        public PageAddCl()
        {
            InitializeComponent();
            if ((TxtCode.Text != "") && (TxtName.Text != ""))
            {
                Users NewUser = new Users()
                {
                    Name = TxtName.Text,
                    Code = Convert.ToInt32(TxtCode.Text),
                    Role_id = 3
                };
                App.Connection.Users.Add(NewUser);
                App.Connection.SaveChanges();
                MessageBox.Show("Добавление прошло успешно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
