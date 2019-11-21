using BLL;
using BLL.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbCrud>().To<DBDataOperations>();
        }
    }
}
