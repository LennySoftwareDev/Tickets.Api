using Microsoft.Extensions.DependencyInjection;
using Tickets.Domain.User;

namespace Tickets.Persistence.Tickets;

public static class UserRepositoryConfiguration
{
    public static void ConfigurationUserRepository(this IServiceCollection services) =>
    services.AddScoped<IUserRepository, UserRepository>();
}
