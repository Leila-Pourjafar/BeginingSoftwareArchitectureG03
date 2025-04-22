using HouseRent.Core.Domain.Amenities.Entities;

namespace HouseRent.Core.Domain.Amenities.Repositories;

public interface IAmentyRepository
{
    Task<Amenity?> GetByIdAsync(int id, CancellationToken cancellationToken = default);

}