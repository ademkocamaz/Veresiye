using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.Entity;

namespace Veresiye.Entity.Concrete
{
    public class CustomerActivity : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}
