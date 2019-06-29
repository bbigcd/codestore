using System.Threading.Tasks;

namespace DependencyInjectionSample.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}