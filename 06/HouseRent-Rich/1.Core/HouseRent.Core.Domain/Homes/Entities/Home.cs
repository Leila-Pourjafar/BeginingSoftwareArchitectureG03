using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Homes.Events;
using HouseRent.Core.Domain.Homes.ValueObjects;
using HouseRent.Core.Domain.Shared.ValueObjects;

namespace HouseRent.Core.Domain.Homes.Entities
{
    public sealed class Home:BaseEntity<int>
    {
        private Home(
            int id,
            Title title,
            Description description,
            Address address,
            Money price,
            List<int> amenities)
            : base(id)
        {
            Title = title;
            Description = description;
            Address = address;
            Price = price;
            Amenities = amenities;
        }

        public Title Title { get; set; }
        public Description Description { get; set; }
        public Address Address { get; set; }
        public Money Price { get; set; }
        public List<int> Amenities { get; private set; } = [];
        public static Home Create(int id,
                          Title title,
                          Description description,
                          Address address,
                          Money price,
                          List<int> amenities)
        {
            var home = new Home(id, title, description, address, price, amenities);
            home.AddDomainEvent(new HomeCreated(id));
            return home;
        }
    }


}
