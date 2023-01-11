
using AsaxiyClone.Domain.Constants;
using AsaxiyClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsaxiyClone.Infrastructure.EntityTypeConfigurations;

public class UserHistoryConfiguration : IEntityTypeConfiguration<UserHistory>
{
    public void Configure(EntityTypeBuilder<UserHistory> builder)
    {
        builder.ToTable(TableName.Histories);

        builder.HasKey(history => history.Id);

        builder.HasOne<User>(history => history.User)
            .WithMany(user => user.UserHistories)
            .HasForeignKey(history => history.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Order>(history => history.Order)
            .WithMany(order => order.UserHistories)
            .HasForeignKey(history => history.OrderId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
