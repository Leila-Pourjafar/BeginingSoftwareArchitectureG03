using HouseRent.Core.Domain.Amenities.Entities;
using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Homes.Entities;

namespace HouseRent.Core.Domain.Homes;

public class HomeAmenity : BaseEntity<long>
{
    public HomeAmenity() { }
    public Home Home { get; set; }
    public Amenity Amenity { get; set; }
    public long HomeId { get; set; }
    public long AmenityId { get; set; }
}