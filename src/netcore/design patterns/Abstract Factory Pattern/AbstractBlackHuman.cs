using System;
namespace Abstract_Factory_Pattern
{
    public abstract class AbstractBlackHuman : IHuman
    {
        public void getColor()
        {
            Console.WriteLine("黑色人种的皮肤颜色是黑色的");
        }

        public void talk()
        {
            Console.WriteLine("黑人会说话，一般人听不懂。");
        }

        public abstract void getSex();
    }
}