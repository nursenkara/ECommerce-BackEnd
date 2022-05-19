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
    public class OrderConfiguration : EntityTypeConfigurationBase<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> entity)
        {
            base.Configure(entity);
            entity.Property(p => p.Count).IsRequired();

            entity.HasMany(e => e.OrderDetails)
                  .WithOne(e => e.Order)
                  .HasForeignKey(e => e.OrderId)
                  .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
