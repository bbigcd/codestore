using Diary.CQRS;

namespace Diary.Web
{
    public static class ServiceLocator
    {
        public static FakeBus Bus { get; set; }
    }
}