using ECommerce.Application.Contracts.Repositories.Commons;
using ECommerce.Domain.Entities.Cargos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Contracts.Repositories.Cargos
{
    public interface ICargoWriteRepository : IWriteRepository<Cargo>
    {
    }
}
