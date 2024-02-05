using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Tickets.Persistence.Context;

public static class PersistenceDbContextConfiguration
{
    public static void ConfigurationPersistenceDbContext(this IServiceCollection services, string connectionString)
    {
        services.TryAddScoped<IPersistenceDbContext, PersistenceDbContext>();
        services.AddDbContextFactory<PersistenceDbContext>(x => x.UseSqlServer(connectionString));
    }
}