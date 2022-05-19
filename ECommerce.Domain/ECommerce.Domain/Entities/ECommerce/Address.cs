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
    public class Address:EntityBase
    {
        public Address()
        {
            Orders = new HashSet<Order>();
        }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("CityId")]
        public int CityId { get; set; }
        public City City { get; set; }
        public string AddressDetail { get; set; }
        public string PostalCode { get; set; }
        public bool Active { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
