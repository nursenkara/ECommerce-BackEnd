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
    public class AddressConfiguration : EntityTypeConfigurationBase<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> entity)
        {
            base.Configure(entity);
            entity.HasMany(e => e.Orders)
                    .WithOne(e => e.Address)
                    .HasForeignKey(e => e.AddressId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
