using System;
using System.Collections.Generic;

namespace OrdenesMVCCore.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public bool CustomerStatus { get; set; }
        public DateTime CustomerBornDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
