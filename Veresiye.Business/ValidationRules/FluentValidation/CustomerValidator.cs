using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Entity.Concrete;

namespace Veresiye.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Calling).NotEmpty().WithMessage("Cari ünvan boş olamaz");
            RuleFor(c => c.Calling).MaximumLength(100);
            RuleFor(c => c.Contact).MaximumLength(100);
            RuleFor(c => c.Gsm).MaximumLength(20);
            RuleFor(c => c.Phone).MaximumLength(20);
            RuleFor(c => c.Fax).MaximumLength(20);
            RuleFor(c => c.Address).MaximumLength(500);
            RuleFor(c => c.City).MaximumLength(20);
            RuleFor(c => c.County).MaximumLength(20);
            RuleFor(c => c.TaxOffice).MaximumLength(100);
            RuleFor(c => c.TaxId).MaximumLength(20);
            RuleFor(c => c.EMail).MaximumLength(100);
            RuleFor(c => c.Web).MaximumLength(100);
        }
    }
}
