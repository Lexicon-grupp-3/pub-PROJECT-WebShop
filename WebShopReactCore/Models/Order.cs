using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopReactCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PayDate { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
