using Application.Core.Base.Mapper.Configuration;
using Application.Core.Tickets;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tickets.Persistence.Context;

namespace Application.Core;

public static class AplicationServiceConfiguration
{
    public static void ConfigurationAplicationService(this IServiceCollection services, string connectionString)
    {
        services.ConfigureMapper();
        services.ConfigurationPersistenceDbContext(connectionString);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

        services.TicketServiceConfigure();
        services.UserServiceConfigure();
    }
}