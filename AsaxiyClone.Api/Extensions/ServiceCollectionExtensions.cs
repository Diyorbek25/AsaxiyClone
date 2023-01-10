using AsaxiyClone.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AsaxiyClone.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbContexts(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlServer");

        services.AddDbContextPool<AsaxiyCloneDBContext>(options =>
        {
            options.UseSqlServer(connectionString, sqlServerOptions =>
            {
                sqlServerOptions.EnableRetryOnFailure();
            });
        });

        return services;
    }
}
