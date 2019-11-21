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
using System.Windows.Shapes;

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        Window openz;
        public Reservation()
        {
            InitializeComponent();
        }

        public void OpenZaselenieClienta(Object sender, RoutedEventArgs e)
        {
            openz = new ZaselenieClienta();
            openz.Owner = this;
            openz.Show();
            this.Hide();
        }
    }
}
