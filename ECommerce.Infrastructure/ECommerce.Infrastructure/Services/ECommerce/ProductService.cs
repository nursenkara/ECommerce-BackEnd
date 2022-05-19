using ECommerce.Application.Contracts.Repositories.Commons;
using ECommerce.Application.Services.ECommerce;
using ECommerce.Domain.Entities.ECommerce;
using ECommerce.Infrastructure.Services.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services.ECommerce
{
    public class ProductService: ServiceBase<Product>, IProductService
    {
        private readonly IReadRepository<Product> _entityReadRepository;
        private readonly IWriteRepository<Product> _entityWriteRepository;

        public ProductService(IReadRepository<Product> entityReadRepository, IWriteRepository<Product> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}
