using System;
namespace Strategy_Pattern
{
    public class GivenGreenLight : IStrategy
    {
        public void operate()
        {
            Console.WriteLine("求吴国太开绿灯,放行！");
        }
    }
}