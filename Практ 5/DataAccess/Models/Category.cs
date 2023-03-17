using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
