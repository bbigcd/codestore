using System;
namespace Abstract_Factory_Pattern
{
    public class MaleYellowHuman : AbstractYellowHuman
    {
        public override void getSex()
        {
            Console.WriteLine("黄色人种男性");
        }
    }
}