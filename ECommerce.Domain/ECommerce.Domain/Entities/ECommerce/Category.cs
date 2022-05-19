using ECommerce.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.ECommerce
{
    public class Category:EntityBase
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }

        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
