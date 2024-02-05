using Tickets.Domain.User;
using Tickets.Persistence.Base;
using Tickets.Persistence.Context;

namespace Tickets.Persistence.Tickets;

public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
{
    public UserRepository(IPersistenceDbContext ticketDbContext) : base(ticketDbContext)
    {
    }
}
