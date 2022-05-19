using ECommerce.Domain.Entities.Authentications;
using ECommerce.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.ECommerce
{
    public class Order:EntityBase
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("AddressId")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("OrderStatusId")]
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int Count { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
