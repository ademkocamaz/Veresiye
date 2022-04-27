using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Entity.Concrete;

namespace Veresiye.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CustomerActivityMap:EntityTypeConfiguration<CustomerActivity>
    {
        public CustomerActivityMap()
        {
            ToTable("CUSTOMERACTIVITY");
            HasKey(a => a.Id);
            Property(a => a.CustomerId).HasColumnName("CUSTOMER_ID");
            Property(a => a.Type).HasColumnName("TYPE");
            Property(a => a.Description).HasColumnName("DESCRIPTION");
            Property(a => a.Total).HasColumnName("TOTAL");
        }
    }
}
