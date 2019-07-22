
using System.Reflection;

namespace Factory_pattern
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HumanFactory<T> : AbstractHumanFactory<T> where T : IHuman
    {
        public override T CreateHuman(string who)
        {
            return (T)Assembly.Load("Factory pattern").CreateInstance($"Factory_pattern.{who}");
        }
    }
}