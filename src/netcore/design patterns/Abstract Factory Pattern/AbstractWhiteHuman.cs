using System;
namespace Abstract_Factory_Pattern
{
    public abstract class AbstractWhiteHuman : IHuman
    {
        //白色人种的皮肤颜色是白色的
        public void getColor()
        {
            Console.WriteLine("白色人种的皮肤颜色是白色的！");
        }
        //白色人种讲话
        public void talk()
        {
            Console.WriteLine("白色人种会说话，一般说的都是单字节。");
        }
        public abstract void getSex();
    }
}