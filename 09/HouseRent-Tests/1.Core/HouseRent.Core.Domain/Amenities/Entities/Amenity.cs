﻿using HouseRent.Core.Domain.Amenities.Events;
using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Shared.ValueObjects;

namespace HouseRent.Core.Domain.Amenities.Entities
{
    public class Amenity : AggregateRoot<long>
    {
        private Amenity(long id,
                        Title title,
                        Money price) : base(id)
        {
            Title = title;
            Price = price;
        }

        public Title Title { get; set; }
        public Money Price { get; set; }


        public static Amenity Create(long id, Title title, Money price)
        {
            var amenity = new Amenity(id, title, price);
            amenity.AddDomainEvent(new AmenityCreated(id));
            return amenity;
        }
    }

}
