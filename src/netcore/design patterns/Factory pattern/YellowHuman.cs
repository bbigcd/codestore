using System;
namespace Factory_pattern
{
    public class YellowHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("黄色人种的皮肤颜色是黄色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黄色人种会说话，一般说的都是双字节。");
        }
    }
}