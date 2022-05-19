using ECommerce.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.ECommerce
{
    public class OrderStatus:EntityBase
    {
        public OrderStatus()
        {
            Orders  = new HashSet<Order>();
        }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
