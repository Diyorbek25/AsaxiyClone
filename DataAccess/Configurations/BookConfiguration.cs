using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(book=> book.Name)
            .HasMaxLength(100);
        builder
            .Property(book=>book.Author)
            .HasMaxLength(100);
        builder
            .HasOne(book => book.Category)
            .WithMany(category => category.Books);
    }
}
