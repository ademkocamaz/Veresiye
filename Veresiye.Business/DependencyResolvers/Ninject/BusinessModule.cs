using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Business.Abstract;
using Veresiye.Business.Concrete.Managers;
using Veresiye.DataAccess.Abstract;
using Veresiye.DataAccess.Concrete.EntityFramework;

namespace Veresiye.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>().InSingletonScope();
            Bind<ICustomerDal>().To<EfCustomerDal>().InSingletonScope();
            
            Bind<ICustomerActivityService>().To<CustomerActivityManager>().InSingletonScope();
            Bind<ICustomerActivityDal>().To<EfCustomerActivityDal>().InSingletonScope();

            Bind<DbContext>().To<VeresiyeDatabaseContext>().InSingletonScope();
        }
    }
}
