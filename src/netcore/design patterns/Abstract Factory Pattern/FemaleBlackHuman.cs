using System;
namespace Abstract_Factory_Pattern
{
    public class FemaleBlackHuman : AbstractBlackHuman
    {
        public override void getSex()
        {
            Console.WriteLine("黑色人种女性");
        }
    }
}