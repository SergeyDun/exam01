using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace exam01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 bd = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            bd.Service.Load();
            lll.ItemsSource = bd.Client.Local;
        }
        private void searc_TextChanged(object sender, TextChangedEventArgs e)
        {
            lll.ItemsSource = bd.Service.Local.Where(x => x.Title.ToLower().Contains(searc.Text.ToLower()));
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Sort.SelectedIndex)
            {
                case 0:
                    lll.ItemsSource = bd.Service.Local.OrderBy(x => x.Title);
                    break;
                case 1:
                    lll.ItemsSource = bd.Service.Local.OrderByDescending(x => x.Title);
                    break;
                default:
                    break;
            }
        }

            private void Filt_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                switch (Filt.SelectedIndex)
                {
                    case 0:
                        lll.ItemsSource = bd.Service.Local;
                        break;
                    case 1:
                        lll.ItemsSource = bd.Service.Local.Where(x => x.Cost <= 500);
                        break;
                    case 2:
                        lll.ItemsSource = bd.Service.Local.Where(x => x.Cost >= 500 && x.Cost <= 1000);
                        break;
                    case 3:
                        lll.ItemsSource = bd.Service.Local.Where(x => x.Cost >= 1000 && x.Cost <= 3000);
                        break;
                    default:
                        break;
                }
            
            }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    }

