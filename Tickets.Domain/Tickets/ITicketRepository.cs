using Tickets.Domain.Base;

namespace Tickets.Domain.Tickets;

public interface ITicketRepository : IRepositoryBase<TicketEntity>, IDisposable
{
}