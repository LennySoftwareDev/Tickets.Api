using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Tickets;
using Tickets.Domain.User;
using Tickets.Persistence.Base.Context;

namespace Tickets.Persistence.Context;

public interface IPersistenceDbContext : IDbContextBase
{
    DbSet<TicketEntity> Ticket { get; }
    DbSet<UserEntity> User { get; }
}