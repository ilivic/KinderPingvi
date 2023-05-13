using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KinderPingui.ADOApp;

namespace KinderPingui.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageAddItemsOrService.xaml
    /// </summary>
    public partial class PageAddItemsOrService : Page
    {
        public static Byte[] image { get; set; }
        public PageAddItemsOrService()
        {
            InitializeComponent();
        }

        private void ChItem_Checked(object sender, RoutedEventArgs e)
        {
            SKNewItem.Visibility = Visibility.Visible;
            SKNewService.Visibility = Visibility.Hidden;
            ChService.IsChecked = false;
        }

        private void ChItem_Unchecked(object sender, RoutedEventArgs e)
        {
            SKNewItem.Visibility = Visibility.Hidden;
            SKNewService.Visibility = Visibility.Visible;
            ChService.IsChecked = true;
        }

        private void ChService_Checked(object sender, RoutedEventArgs e)
        {
            SKNewItem.Visibility = Visibility.Hidden;
            SKNewService.Visibility = Visibility.Visible;
            ChItem.IsChecked = false;
        }

        private void ChService_Unchecked(object sender, RoutedEventArgs e)
        {
            SKNewItem.Visibility = Visibility.Visible;
            SKNewService.Visibility = Visibility.Hidden;
            ChItem.IsChecked = true ;
        }

        private void ClickSelectPhoto(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() != null)
                {
                    image = File.ReadAllBytes(dialog.FileName);
                    MessageBox.Show("Фото Добавленно");

                }
                else
                {
                    MessageBox.Show("Ничего не выбранно");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void ClickAddNewUtem(object sender, RoutedEventArgs e)
        {
            try
            {
                int NewPrice = Convert.ToInt32(TxtPriceNewItem.Text);
                Items NewItem = new Items()
                {
                    Photo = image,
                    Price = NewPrice,
                    Title = TxtTitleNeItem.Text
                };
                if (MessageBox.Show("Добавить Новый Предмет?", "Вопросик", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.Connection.Items.Add(NewItem);
                    App.Connection.SaveChanges();
                    MessageBox.Show($"предмет {NewItem.Title} Добавлен успешно","Информация");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClickAddNewService(object sender, RoutedEventArgs e)
        {
            try
            {
                int NewPrice = Convert.ToInt32(TxtNewPriceService.Text);
                PriceList NewService = new PriceList()
                {
                    Photo = image,
                    Price = NewPrice,
                    Title = TxtNewService.Text
                };
                if (MessageBox.Show("Добавить Новый Предмет?", "Вопросик", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    App.Connection.PriceList.Add(NewService);
                    App.Connection.SaveChanges();
                    MessageBox.Show($"Услуга {NewService.Title} Добавлена успешно", "Информация");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
