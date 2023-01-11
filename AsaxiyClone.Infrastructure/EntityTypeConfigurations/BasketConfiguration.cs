
using AsaxiyClone.Domain.Constants;
using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.ToTable(TableName.Baskets);

        builder.HasKey(basket => basket.Id);

        builder.Property(basket => basket.Pieces)
            .IsRequired();

        builder.HasOne<User>(basket => basket.User)
            .WithOne(user => user.Basket)
            .HasForeignKey<Basket>(basket => basket.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Book>(basket => basket.Book)
            .WithOne()
            .HasForeignKey<Basket>(basket => basket.BookId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
