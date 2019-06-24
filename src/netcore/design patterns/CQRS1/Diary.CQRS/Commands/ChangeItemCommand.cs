using System;
namespace Diary.CQRS.Commands
{
    public class ChangeItemCommand : Command
    {
        public DateTime To { get; private set; }
        public DateTime From { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public ChangeItemCommand(Guid aggregateId, string title,
         string description, DateTime from, DateTime to, int version) : base(aggregateId, version)
        {
            To = to;
            From = from;
            Description = description;
            Title = title;
        }
    }
}