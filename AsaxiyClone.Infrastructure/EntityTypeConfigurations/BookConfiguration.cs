using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable(nameof(Category))
                .HasKey(book => book.Id);

            builder.Property(book => book.Name)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(book => book.Author)
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(book => book.Price)
                .IsRequired(true);

            builder.Property(book => book.Status)
                .IsRequired(true);

            builder.Property(book => book.Image)
                .IsRequired(false);

            builder.Property(book => book.Rating)
                .IsRequired(false);

            builder.HasOne<Category>(book => book.Category)
                .WithMany(category => category.Books)
                .HasForeignKey(book => book.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasMany(book => book.Comments)
                .WithOne(comment => comment.Book)   
                .HasForeignKey(comment => comment.BookId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
