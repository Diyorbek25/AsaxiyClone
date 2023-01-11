using AsaxiyClone.Domain.Constants;
using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable(TableName.Comments);

        builder.HasKey(comment => comment.Id);

        builder.Property(comment => comment.Body)
            .HasMaxLength(200)
            .IsRequired(true);

        builder.HasOne<User>(comment => comment.User)
            .WithMany(user => user.Comments)
            .HasForeignKey(comment => comment.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Book>(comment => comment.Book)
            .WithMany(book => book.Comments)
            .HasForeignKey(comment => comment.BookId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
