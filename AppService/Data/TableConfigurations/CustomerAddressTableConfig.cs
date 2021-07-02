using Domain.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppService.Data.TableConfigurations
{
    public class CustomerAddressTableConfig : TableConfiguration<CustomerAddress>
    {
        public override void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable(TableConstants.CustomerAddresses);
        }
    }
}
