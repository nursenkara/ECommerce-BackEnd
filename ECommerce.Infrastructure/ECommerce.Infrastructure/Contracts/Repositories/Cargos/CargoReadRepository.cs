using ECommerce.Application.Contracts.Repositories.Cargos;
using ECommerce.Domain.Entities.Cargos;
using ECommerce.Infrastructure.Contracts.Repositories.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Contracts.Repositories.Cargos
{
    public class CargoReadRepository : ReadRepository<Cargo>, ICargoReadRepository
    {
        public CargoReadRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
