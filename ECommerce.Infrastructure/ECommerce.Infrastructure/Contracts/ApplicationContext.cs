using ECommerce.Domain.Configurations.ECommerce;
using ECommerce.Domain.Entities.Authentications;
using ECommerce.Domain.Entities.Cargos;
using ECommerce.Domain.Entities.Commons;
using ECommerce.Domain.Entities.ECommerce;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public class ApplicationContext: IdentityDbContext<User,Role,int>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.LastModifiedDate = DateTime.Now;

                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region ECommerce

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            #endregion
        }

        #region ECommerce

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        #endregion

        #region Cargos

        public DbSet<Cargo> Cargos { get; set; }

        #endregion

    }
}
