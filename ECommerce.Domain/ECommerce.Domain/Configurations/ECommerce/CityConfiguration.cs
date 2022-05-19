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
    public class CityConfiguration:EntityTypeConfigurationBase<City>
    {
        public override void Configure(EntityTypeBuilder<City> entity)
        {
            base.Configure(entity);

        }
    }
}
