using HouseRent.Core.Domain.Framework;
using System.Runtime.CompilerServices;

namespace HouseRent.Core.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(long BookingId) : IDomainEvent;