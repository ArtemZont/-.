using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Item
    {
        public Item()
        {
            Carts = new HashSet<Cart>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public int WarehouseAmount { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
