using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Business.Abstract;
using Veresiye.Business.ValidationRules.FluentValidation;
using Veresiye.Core.Aspects.Postsharp.CacheAspects;
using Veresiye.Core.CrossCuttingConcerns.Caching.Microsoft;
using Veresiye.Core.Utilities.Validation;
using Veresiye.DataAccess.Abstract;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.Concrete.Managers
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            this.customerDal = customerDal;
        }
        public void Add(Customer entity)
        {
            ValidationTool.Validate(new CustomerValidator(),entity);
            customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            customerDal.Delete(entity);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            return customerDal.Get(filter);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return customerDal.GetAll(filter);
        }

        public void Update(Customer entity)
        {
            ValidationTool.Validate(new CustomerValidator(), entity);
            customerDal.Update(entity);
        }
    }
}
