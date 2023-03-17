using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Cart
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Item Item { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
