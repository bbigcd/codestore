using System;
namespace Strategy_Pattern
{
    public class BackDoor : IStrategy
    {
        public void operate()
        {
            Console.WriteLine("找乔国老帮忙，让吴国太给孙权施加压力");
        }
    }
}