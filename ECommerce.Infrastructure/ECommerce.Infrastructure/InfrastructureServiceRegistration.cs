using ECommerce.Application.Contracts.Repositories.Cargos;
using ECommerce.Application.Contracts.Repositories.Commons;
using ECommerce.Application.Contracts.Repositories.ECommerce.Categories;
using ECommerce.Application.Contracts.Repositories.ECommerce.Products;
using ECommerce.Application.Services.Cargos;
using ECommerce.Application.Services.Commons;
using ECommerce.Application.Services.ECommerce;
using ECommerce.Infrastructure.Contracts.Repositories.Cargos;
using ECommerce.Infrastructure.Contracts.Repositories.Commons;
using ECommerce.Infrastructure.Contracts.Repositories.ECommerce.Categories;
using ECommerce.Infrastructure.Contracts.Repositories.ECommerce.Products;
using ECommerce.Infrastructure.Services.Cargos;
using ECommerce.Infrastructure.Services.Commons;
using ECommerce.Infrastructure.Services.ECommerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                                      options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            #region Commons

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));


            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));


            #endregion

            #region ECommerce

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICategoryService, CategoryService>();



            #endregion
            #region Cargos

            services.AddScoped<ICargoReadRepository, CargoReadRepository>();
            services.AddScoped<ICargoWriteRepository, CargoWriteRepository>();
            services.AddScoped<ICargoService, CargoService>();



            #endregion

            return services;
        }
    }
}
