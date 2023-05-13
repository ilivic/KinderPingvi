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
using System.IO;
using PingvinAdmin.ClassApp;
using Microsoft.Win32;
using System.Runtime.Remoting.Messaging;

namespace PingvinAdmin.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageServiceShow.xaml
    /// </summary>
    public partial class PageServiceShow : Page
    {
        public PageServiceShow()
        {
            InitializeComponent();
            ListService.ItemsSource = App.Connection.ItemOrder.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    OpenFileDialog dialog = new OpenFileDialog();
            //    if (dialog.ShowDialog() == true) 
            //    {
            //    }
            //    using (ClassExcel helper = new ClassExcel())
            //    {
            //        MessageBox.Show(dialog.FileName);
            //        helper.Open(filePath: Path.Combine(Environment.CurrentDirectory, dialog.FileName))
             //       foreach()
            //{
            //    helper.Set(column: "A", row: 1, data: "lksadklsajdkl");
            //}
            //            helper.Save();
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
