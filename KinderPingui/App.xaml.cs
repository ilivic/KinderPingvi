using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KinderPingui.ADOApp;

namespace KinderPingui
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Публичное обращение к базе данных
        /// </summary>
        public static KinderPingviEntities Connection = new KinderPingviEntities();
    }
}
