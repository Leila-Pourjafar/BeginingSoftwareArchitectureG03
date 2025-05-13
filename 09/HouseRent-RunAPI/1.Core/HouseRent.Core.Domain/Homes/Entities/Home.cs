using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Homes.Events;
using HouseRent.Core.Domain.Homes.ValueObjects;
using HouseRent.Core.Domain.Shared.ValueObjects;

namespace HouseRent.Core.Domain.Homes.Entities
{
    public sealed class Home: AggregateRoot<long>
    {
        private Home(
            int id,
            Title title,
            Description description,
            Address address,
            Money price,
            List<HomeAmenity> amenities)
            : base(id)
        {
            Title = title;
            Description = description;
            Address = address;
            Price = price;
            HomeAmenities = amenities;
        }
        private Home() : base()
        {

        }
        public Title Title { get; set; }
        public Description Description { get; set; }
        public Address Address { get; set; }
        public Money Price { get; set; }
        public DateTime? LastBookedOnUtc { get; internal set;}

        public List<HomeAmenity> HomeAmenities { get; private set; } = [];
        public static Home Create(int id,
                          Title title,
                          Description description,
                          Address address,
                          Money price,
                          List<HomeAmenity> amenities)
        {
            var home = new Home(id, title, description, address, price, amenities);
            home.AddDomainEvent(new HomeCreated(id));
            return home;
        }


        public Result Reserve(DateTime dateTimeUtc)
        {
            LastBookedOnUtc = dateTimeUtc;
            AddDomainEvent(new HomeBooked(Id));
            return Result.Success();
        }
    }


}
