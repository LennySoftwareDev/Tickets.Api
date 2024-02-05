using Microsoft.Extensions.DependencyInjection;
using Tickets.Domain.Tickets;

namespace Tickets.Persistence.Tickets;

public static class TicketRepositoryConfiguration
{
    public static void ConfigurationTicketRepository(this IServiceCollection services) =>
    services.AddScoped<ITicketRepository, TicketRepository>();
}
