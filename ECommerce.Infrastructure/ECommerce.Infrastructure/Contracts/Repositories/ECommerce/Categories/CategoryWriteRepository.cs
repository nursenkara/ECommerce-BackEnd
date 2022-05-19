using ECommerce.Application.Contracts.Repositories.ECommerce.Categories;
using ECommerce.Domain.Entities.ECommerce;
using ECommerce.Infrastructure.Contracts.Repositories.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Contracts.Repositories.ECommerce.Categories
{
    public class CategoryWriteRepository:WriteRepository<Category>,ICategoryWriteRepository
    {
        public CategoryWriteRepository(ApplicationContext context):base(context)
        {

        }
    }
}
