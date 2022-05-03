using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.DataAccess;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.Abstract
{
    public interface ICustomerActivityService : IEntityRepository<CustomerActivity>
    {
        Task<List<CustomerActivity>> GetAllAsync(Expression<Func<CustomerActivity, bool>> filter = null);
        decimal BakiyeHesapla(Customer customer);
    }
}
