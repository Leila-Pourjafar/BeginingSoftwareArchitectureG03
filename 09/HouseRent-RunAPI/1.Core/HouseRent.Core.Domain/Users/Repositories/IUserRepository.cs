using HouseRent.Core.Domain.Users.Entities;

namespace HouseRent.Core.Domain.Users.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(long id, CancellationToken cancellationToken = default);
}