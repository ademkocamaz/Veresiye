using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Business.Abstract;
using Veresiye.Business.ValidationRules.FluentValidation;
using Veresiye.Core.Utilities.Validation;
using Veresiye.DataAccess.Abstract;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.Concrete.Managers
{
    public class CustomerActivityManager : ICustomerActivityService
    {
        private ICustomerActivityDal customerActivityDal;
        private ICustomerDal customerDal;

        public CustomerActivityManager(ICustomerActivityDal customerActivityDal,ICustomerDal customerDal)
        {
            this.customerActivityDal = customerActivityDal;
            this.customerDal = customerDal;
        }
        public void Add(CustomerActivity entity)
        {
            ValidationTool.Validate(new CustomerActivityValidator(), entity);
            customerActivityDal.Add(entity);
        }

        public decimal BakiyeHesapla(Customer customer)
        {
            decimal borc = customerActivityDal.GetAll(a => a.Type.Equals("Borç") | a.Type.Equals("Ödeme") && a.CustomerId.Equals(customer.Id)).Select(i => i.Total).Sum();
            decimal alacak = customerActivityDal.GetAll(a => a.Type.Equals("Alacak") | a.Type.Equals("Tahsilat") && a.CustomerId.Equals(customer.Id)).Select(i => i.Total).Sum();
            decimal bakiye = borc - alacak;

            customer.Balance = bakiye;
            customerDal.Update(customer);
            return bakiye;
        }

        public void Delete(CustomerActivity entity)
        {
            customerActivityDal.Delete(entity);
        }

        public CustomerActivity Get(Expression<Func<CustomerActivity, bool>> filter)
        {
            return customerActivityDal.Get(filter);
        }

        public List<CustomerActivity> GetAll(Expression<Func<CustomerActivity, bool>> filter = null)
        {
            return customerActivityDal.GetAll(filter);
        }

        public void Update(CustomerActivity entity)
        {
            ValidationTool.Validate(new CustomerActivityValidator(), entity);
            customerActivityDal.Update(entity);
        }
    }
}
