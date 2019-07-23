using System;
namespace Abstract_Factory_Pattern
{
    public class MaleWhiteHuman : AbstractWhiteHuman
    {
        public override void getSex()
        {
            Console.WriteLine("白色人种男性");
        }
    }
}