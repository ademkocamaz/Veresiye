using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.DataAccess;
using Veresiye.DataAccess.Concrete.EntityFramework.Mappings;
using Veresiye.Entity.Concrete;

namespace Veresiye.DataAccess.Concrete.EntityFramework
{
    public class VeresiyeDatabaseContext : DbContext
    {
        public VeresiyeDatabaseContext() : base(new FbConnection(VeresiyeDatabase.connectionString), true)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerActivity> CustomerActivities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Properties().Configure(x => x.HasColumnName(x.ClrPropertyInfo.Name.ToUpper()));

            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerActivityMap());
        }
    }
}
