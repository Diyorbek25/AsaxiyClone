using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class AppDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AsaxiyDB;Trusted_Connection=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
