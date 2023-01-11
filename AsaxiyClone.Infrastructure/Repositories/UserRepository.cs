using AsaxiyClone.Domain.Entities;
using AsaxiyClone.Infrastructure.Contexts;

namespace AsaxiyClone.Infrastructure.Repositories;

public class UserRepository : GenericRepository<User, Guid>, IGeneralRepository<User, Guid>
{
	public UserRepository(AsaxiyCloneDBContext dBContext)
		: base(dBContext)
	{
	}
}
