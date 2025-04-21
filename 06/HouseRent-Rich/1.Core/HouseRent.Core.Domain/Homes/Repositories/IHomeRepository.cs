using HouseRent.Core.Domain.Homes.Entities;

namespace HouseRent.Core.Domain.Homes.Repositories
{
    internal interface IHomeRepository
    {
        public interface IHomeRepository
        {
            Task<Home?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        }
    }
}
