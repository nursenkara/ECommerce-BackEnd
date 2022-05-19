using ECommerce.Domain.Configurations.Commons;
using ECommerce.Domain.Entities.ECommerce;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Configurations.ECommerce
{
    public class OrderDetailConfiguration:EntityTypeConfigurationBase<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> entity)
        {
            base.Configure(entity);
            entity.Property(p => p.Count).IsRequired();
            entity.Property(p => p.SalePrice).IsRequired();

        }
    }
}
