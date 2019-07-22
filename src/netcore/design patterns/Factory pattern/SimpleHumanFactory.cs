using System.Reflection;

namespace Factory_pattern
{
    /// <summary>
    /// 简单工厂、静态工厂
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SimpleHumanFactory<T> where T : IHuman
    {
        public static T CreateHuman(string who)
        {
            return (T)Assembly.Load("Factory pattern").CreateInstance($"Factory_pattern.{who}");
        }
    }
}