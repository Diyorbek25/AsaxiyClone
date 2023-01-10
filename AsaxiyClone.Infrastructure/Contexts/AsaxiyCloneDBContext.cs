using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AsaxiyClone.Infrastructure.Contexts;

public class AsaxiyCloneDBContext : DbContext
{
    public AsaxiyCloneDBContext(DbContextOptions<AsaxiyCloneDBContext> dbContextOptions)
        : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());
    }
}
