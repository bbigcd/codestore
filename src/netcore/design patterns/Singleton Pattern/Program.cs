using System;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int day = 0; day < 3; day++)
            {
                Emperor emperor = Emperor.getInstance();
                emperor.say();

                Emperor.Instance.say("我还是这个皇帝...");
            }
        }
    }
}
