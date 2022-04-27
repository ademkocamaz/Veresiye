using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.ValidationRules.FluentValidation
{
    public class CustomerActivityValidator : AbstractValidator<CustomerActivity>
    {
        public CustomerActivityValidator()
        {
            RuleFor(a => a.CustomerId).NotEmpty();
            RuleFor(a => a.Type).MaximumLength(20);
            RuleFor(a => a.Description).MaximumLength(100);
            RuleFor(a => a.Total).GreaterThan(0);
        }
    }
}
