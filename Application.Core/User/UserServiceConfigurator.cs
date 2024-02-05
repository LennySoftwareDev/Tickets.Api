using Microsoft.Extensions.DependencyInjection;
using Tickets.Persistence.Tickets;

namespace Application.Core.Tickets;

public static class UserServiceConfigurator
{
    public static void UserServiceConfigure(this IServiceCollection services)
    {
        services.ConfigurationUserRepository();
    }
}