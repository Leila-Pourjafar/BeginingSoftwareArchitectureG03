using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(int UserId) : IDomainEvent;