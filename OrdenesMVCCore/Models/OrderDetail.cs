using System;
using System.Collections.Generic;

namespace OrdenesMVCCore.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemDescription { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal PriceEach { get; set; }
        public decimal PriceTotal { get; set; }

        public virtual Order Order { get; set; } = null!;
    }
}
