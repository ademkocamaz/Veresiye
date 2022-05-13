using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.DataAccess.EntityFramework;
using Veresiye.DataAccess.Abstract;
using Veresiye.Entity.Concrete;

namespace Veresiye.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, VeresiyeDatabaseContext>,ICustomerDal
    {
    }
}
