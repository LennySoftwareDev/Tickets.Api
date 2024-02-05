using Tickets.Domain.Tickets;
using Tickets.Persistence.Base;
using Tickets.Persistence.Context;

namespace Tickets.Persistence.Tickets;

public class TicketRepository : RepositoryBase<TicketEntity>, ITicketRepository
{
    public TicketRepository(IPersistenceDbContext ticketDbContext) : base(ticketDbContext)
    {
    }
}
