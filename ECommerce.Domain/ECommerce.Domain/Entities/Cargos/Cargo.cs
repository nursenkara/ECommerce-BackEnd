using ECommerce.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities.Cargos
{
    public class Cargo : EntityBase
    {
        public string Name { get; set; }
        public int CargoEnumId { get; set; }
    }
}
