using System;
namespace Factory_pattern
{
    public class WhiteHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("白色人种的皮肤颜色是白色的！");
        }

        public void Talk()
        {
            Console.WriteLine("白色人种会说话，一般都是但是单字节。");
        }
    }
}