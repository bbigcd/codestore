using System;
namespace Diary.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}