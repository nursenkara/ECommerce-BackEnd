using ECommerce.Application.Contracts.Repositories.ECommerce.Products;
using ECommerce.Domain.Entities.ECommerce;
using ECommerce.Infrastructure.Contracts.Repositories.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Contracts.Repositories.ECommerce.Products
{
    public class ProductReadRepository: ReadRepository<Product>,IProductReadRepository
    {
        public ProductReadRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
