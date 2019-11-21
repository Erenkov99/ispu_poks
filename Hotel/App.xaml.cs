using BLL;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ninject;
using Hotel.Util;
using BLL.Util;

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        App()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("HotelMod"));
            IDbCrud crudServ = kernel.Get<IDbCrud>();
            App app = new App();
            MainWindow window = new MainWindow(crudServ);
            app.Run(window);
        }
    }
}
