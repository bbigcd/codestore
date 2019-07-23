using System;
namespace Abstract_Factory_Pattern
{
    public abstract class AbstractYellowHuman : IHuman
    {
        public void getColor()
        {
            Console.WriteLine("黄色人种的皮肤颜色是黄色的");
        }

        public void talk()
        {
            Console.WriteLine("黄色人种会说话，一般说的都是双字节。");
        }
        public abstract void getSex();
    }
}