using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Timur.Pages;

namespace Timur
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnZakaz_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ton1());


        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage());

        }

        private void btnYslygi_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new bibika());

        }

        private void btnSotryd_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pahte1());

        }

        private void btnServise_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new wild());

        }

        private void btnOtziv_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new bulk());
        }
    }
}
