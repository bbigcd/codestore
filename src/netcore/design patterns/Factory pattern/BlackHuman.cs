using System;
namespace Factory_pattern
{
    public class BlackHuman : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("黑色人种的皮肤颜色是黑色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黑人会说话，一般人听不懂。");
        }
    }
}