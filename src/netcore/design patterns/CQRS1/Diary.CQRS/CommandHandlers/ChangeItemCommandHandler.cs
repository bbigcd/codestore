using System;
using Diary.CQRS.Commands;
using Diary.CQRS.Storage;
using Diary.CQRS.Domain;

namespace Diary.CQRS.CommandHandlers
{
    public class ChangeItemCommandHandler : ICommandHandler<ChangeItemCommand>
    {
        private readonly IRepository<DiaryItem> _repository;
        public ChangeItemCommandHandler(IRepository<DiaryItem> repository)
        {
            _repository = repository;
        }

        public void Execute(ChangeItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized");
            }

            var aggregate = _repository.GetById(command.Id);

            if (aggregate.Title != command.Title)
                aggregate.ChangeTitle(command.Title);
        }
    }
}