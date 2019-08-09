using System;
namespace Strategy_Pattern
{
    public class BlockEnemy : IStrategy
    {
        public void operate()
        {
            Console.WriteLine("孙夫人断后，挡住追兵");
        }
    }
}