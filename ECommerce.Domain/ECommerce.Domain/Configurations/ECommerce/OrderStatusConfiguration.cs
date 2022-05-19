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
    public class OrderStatusConfiguration:EntityTypeConfigurationBase<OrderStatus>
    {
        public override void Configure(EntityTypeBuilder<OrderStatus> entity)
        {
            base.Configure(entity);

            entity.Property(p => p.Name).IsRequired();

            entity.HasMany(e => e.Orders)
                .WithOne(e => e.OrderStatus)
                .HasForeignKey(e => e.OrderStatusId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
