using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Core.Entity;

namespace Veresiye.Entity.Concrete
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Calling { get; set; }
        public string Contact { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string TaxOffice { get; set; }
        public string TaxId { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }

        public decimal Balance { get; set; }

    }
}
