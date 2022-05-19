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
    public class CategoryService:ServiceBase<Category>,ICategoryService
    {
        private readonly IReadRepository<Category> _entityReadRepository;
        private readonly IWriteRepository<Category> _entityWriteRepository;

        public CategoryService(IReadRepository<Category> entityReadRepository, IWriteRepository<Category> entityWriteRepository):base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));
        }
    }
}
