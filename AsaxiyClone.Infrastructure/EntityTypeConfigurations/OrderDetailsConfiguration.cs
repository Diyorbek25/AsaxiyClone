using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.ToTable(nameof(OrderDetail))
            .HasKey(orderDetail => orderDetail.Id);

        builder.Property(orderDetail => orderDetail.OrderTime)
            .IsRequired(true);

        builder.Property(orderDetail => orderDetail.DeliveryTime)
            .IsRequired(true);

        builder.HasOne(orderDetail => orderDetail.Book)
            .WithMany();

    }
}
