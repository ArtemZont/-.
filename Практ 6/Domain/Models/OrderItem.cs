using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Item Item { get; set; } = null!;
    }
}
