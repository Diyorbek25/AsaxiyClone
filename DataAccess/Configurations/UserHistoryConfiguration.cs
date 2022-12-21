using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserHistoryConfiguration : IEntityTypeConfiguration<UserHistory>
{
    public void Configure(EntityTypeBuilder<UserHistory> builder)
    {
        throw new NotImplementedException();
    }
}
