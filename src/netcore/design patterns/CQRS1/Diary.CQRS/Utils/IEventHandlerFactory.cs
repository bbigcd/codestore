using Diary.CQRS.Events;
using Diary.CQRS.EventHandlers;
using System.Collections.Generic;

namespace Diary.CQRS.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}