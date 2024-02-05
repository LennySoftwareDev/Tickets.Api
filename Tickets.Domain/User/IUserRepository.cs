using Tickets.Domain.Base;

namespace Tickets.Domain.User;

public interface IUserRepository : IRepositoryBase<UserEntity>, IDisposable
{
}