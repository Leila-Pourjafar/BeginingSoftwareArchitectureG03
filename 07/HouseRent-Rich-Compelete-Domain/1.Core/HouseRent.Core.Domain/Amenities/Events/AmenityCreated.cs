using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Amenities.Events;
public record AmenityCreated(int AmenityId) : IDomainEvent;
