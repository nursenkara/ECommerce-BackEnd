using ECommerce.Application.Contracts.Repositories.Commons;
using ECommerce.Domain.Entities.ECommerce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Contracts.Repositories.ECommerce.Products
{
    public interface IProductReadRepository:IReadRepository<Product>
    {
    }
}
