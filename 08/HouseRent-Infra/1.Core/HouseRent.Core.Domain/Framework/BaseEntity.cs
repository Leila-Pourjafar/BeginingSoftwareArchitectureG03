using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRent.Core.Domain.Framework
{
    public abstract class BaseEntity<TId>(TId id)
    {
        private readonly List<IDomainEvent> _events = [];
        public TId Id { get; set; } = id;

        protected void AddDomainEvent(IDomainEvent domainEvent)
        {
            _events.Add(domainEvent);
        }

        protected void ClearDomainEvent(IDomainEvent domainEvent)
        {
            _events.Clear();
        }
        public IReadOnlyList<IDomainEvent> DomainEvents => _events;


    }
}
