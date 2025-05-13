using HouseRent.Core.Domain.Framework;
using HouseRent.Core.Domain.Users.Events;
using HouseRent.Core.Domain.Users.ValueObjects;

namespace HouseRent.Core.Domain.Users.Entities
{
    public sealed class User: AggregateRoot<long>
    {
        private User(long id,
                     FirstName firstName,
                     LastName lastName,
                     Email email)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public FirstName FirstName { get; set; }
        public LastName LastName { get; set; }
        public Email Email { get; set; }

        public static User Create(int id, FirstName firstName, LastName lastName, Email email)
        {
            var user = new User(id, firstName, lastName, email);

            user.AddDomainEvent(new UserCreatedDomainEvent(id));

            return user;
        }
    }


}
