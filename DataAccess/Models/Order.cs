using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int DeliveryTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }

        public virtual DeliveryType DeliveryType { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
