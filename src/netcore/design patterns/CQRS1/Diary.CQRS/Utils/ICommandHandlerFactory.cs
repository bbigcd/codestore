using Diary.CQRS.Commands;
using Diary.CQRS.CommandHandlers;

namespace Diary.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}