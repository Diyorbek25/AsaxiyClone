using AsaxiyClone.Domain.Constants;
using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(TableName.Addresses);

        builder.HasKey(address => address.Id);

        builder.Property(address => address.Description)
            .HasMaxLength(150)
            .IsRequired(false);
        builder.Property(address => address.PostalCode)
            .IsRequired(false);
    }
}
