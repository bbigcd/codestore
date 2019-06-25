using System;
using Diary.CQRS.Domain;
using Diary.CQRS.Events;
using Diary.CQRS.Domain.Mementos;
using System.Collections.Generic;

namespace Diary.CQRS.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T : BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}