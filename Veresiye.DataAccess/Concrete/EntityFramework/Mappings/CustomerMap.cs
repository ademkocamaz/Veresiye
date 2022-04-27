using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Entity.Concrete;

namespace Veresiye.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerMap:EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("CUSTOMERS");
            HasKey(c => c.Id);
            Property(c => c.Calling).HasColumnName("CALLING");
            Property(c => c.Contact).HasColumnName("CONTACT");
            Property(c => c.Gsm).HasColumnName("GSM");
            Property(c => c.Phone).HasColumnName("PHONE");
            Property(c => c.Fax).HasColumnName("FAX");
            Property(c => c.Address).HasColumnName("ADDRESS");
            Property(c => c.City).HasColumnName("CITY");
            Property(c => c.County).HasColumnName("COUNTY");
            Property(c => c.TaxOffice).HasColumnName("TAXOFFICE");
            Property(c => c.TaxId).HasColumnName("TAXID");
            Property(c => c.EMail).HasColumnName("EMAIL");
            Property(c => c.Web).HasColumnName("WEB");
            Property(c => c.Balance).HasColumnName("BALANCE");
        }
    }
}
