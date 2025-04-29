using HouseRent.Core.Domain.Homes.Entities;

namespace HouseRent.Core.Domain.Homes.Repositories
{

    public interface IHomeRepository
    {
        Task<Home?> GetByIdAsync(long id, CancellationToken cancellationToken = default);
    }
}
