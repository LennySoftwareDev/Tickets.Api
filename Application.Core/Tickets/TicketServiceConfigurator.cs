using Microsoft.Extensions.DependencyInjection;
using Tickets.Persistence.Tickets;

namespace Application.Core.Tickets;

public static class TicketServiceConfigurator
{
    public static void TicketServiceConfigure(this IServiceCollection services)
    {
        services.ConfigurationTicketRepository();
    }
}