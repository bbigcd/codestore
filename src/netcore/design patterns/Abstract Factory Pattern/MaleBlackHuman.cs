using System;
namespace Abstract_Factory_Pattern
{
    public class MaleBlackHuman : AbstractBlackHuman
    {
        public override void getSex()
        {
            Console.WriteLine("黑色人种男性");
        }
    }
}