using HouseRent.Core.Domain.Amenities.Events;
using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Shared.ValueObjects;

namespace HouseRent.Core.Domain.Amenities.Entities
{
    public sealed class Amenity: AggregateRoot<long>
    {
        private Amenity(int id,
                        Title title,
                        Money price) : base(id)
        {
            Title = title;
            Price = price;
        }

        public Title Title { get; set; }
        public Money Price { get; set; }


        public static Amenity Create(int id, Title title, Money price)
        {
            var amenity = new Amenity(id, title, price);
            amenity.AddDomainEvent(new AmenityCreated(id));
            return amenity;
        }
    }
}
