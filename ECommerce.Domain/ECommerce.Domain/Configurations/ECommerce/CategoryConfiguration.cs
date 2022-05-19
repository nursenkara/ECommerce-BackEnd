using ECommerce.Domain.Configurations.Commons;
using ECommerce.Domain.Entities.ECommerce;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Configurations.ECommerce
{
    public class CategoryConfiguration : EntityTypeConfigurationBase<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> entity)
        {
            base.Configure(entity);
            
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

            entity.HasMany(e => e.Products)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
