using BLL.Interfaces;
using BLL.Models;
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

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window Bron;

        IDbCrud dbOperations;

        List<ClientModel> allClients;
        public MainWindow(IDbCrud crudDb)
        {
            dbOperations = crudDb;
            loadData();
            InitializeComponent();
            g.ItemsSource = allClients;
        }

        private void loadData()
        {
            allClients = dbOperations.GetAllClients();
            //g.ItemsSource = allClients;
        }

        public void OpenBron(Object sender, RoutedEventArgs e)
        {
            Bron = new Reservation();
            Bron.Show();
        }

        
    }
}
