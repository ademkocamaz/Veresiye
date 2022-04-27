using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.DataAccess;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.Abstract
{
    public interface ICustomerActivityService : IEntityRepository<CustomerActivity>
    {
        decimal BakiyeHesapla(Customer customer);
    }
}
