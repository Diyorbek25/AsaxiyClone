using AsaxiyClone.Domain.Constants;
using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(TableName.Users);

        builder.HasKey(user => user.Id);

        builder.Property(user => user.FullName)
            .HasMaxLength(100)
            .IsRequired(true);
        builder.Property(user => user.Email)
            .HasMaxLength(50)
            .IsRequired(false);
        builder.Property(user => user.PhoneNumber)
            .HasMaxLength(30)
            .IsRequired();

        builder.HasOne<Address>(user => user.Address)
            .WithOne()
            .HasForeignKey<User>(user => user.AddressId);
    }
}