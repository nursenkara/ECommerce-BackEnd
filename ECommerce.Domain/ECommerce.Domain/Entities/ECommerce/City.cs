using ECommerce.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.ECommerce
{
    public class City:EntityBase
    {
        [ForeignKey("CountryId")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
