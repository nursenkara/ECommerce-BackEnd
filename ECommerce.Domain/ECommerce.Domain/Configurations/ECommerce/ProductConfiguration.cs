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
    public class ProductConfiguration : EntityTypeConfigurationBase<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> entity)
        {
            base.Configure(entity);

            entity.Property(p => p.Name).IsRequired();
            entity.Property(p => p.Price).IsRequired();


            #region Index

            entity.HasIndex(e => e.Code, "UIX_Code").IsUnique();

            #endregion
        }
    }
}
