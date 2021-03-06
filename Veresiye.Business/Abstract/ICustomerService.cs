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
    public interface ICustomerService:IEntityRepository<Customer>
    {
        Task<List<Customer>> GetAllAsync(Expression<Func<Customer, bool>> filter = null);
    }
}
