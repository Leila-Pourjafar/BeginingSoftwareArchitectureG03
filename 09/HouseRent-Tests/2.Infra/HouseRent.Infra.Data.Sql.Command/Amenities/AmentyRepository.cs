using HouseRent.Core.Domain.Amenities.Entities;
using HouseRent.Core.Domain.Amenities.Repositories;
using HouseRent.Infra.Data.Sql.Command.Framework;
using HouseRent.Infra.Data.Sql.Command.Shared;
using Microsoft.EntityFrameworkCore;

namespace HouseRent.Infra.Data.Sql.Command.Amenities;
internal class AmentyRepository(HouseRentDbContext dbContext) :
    BaseCommandRepository<Amenity, long>(dbContext), IAmentyRepository
{
    public async Task<List<Amenity>> GetAmenitiesAsync(List<long> amenityIds, CancellationToken cancellationToken = default)
    {
  
        return await DbContext.Amenities.Where(c => amenityIds.Any(d=>d == c.Id)).ToListAsync();
    }

    public Task<List<Amenity>> GetAmenitiesAsync(List<int> amenityIds, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Amenity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
