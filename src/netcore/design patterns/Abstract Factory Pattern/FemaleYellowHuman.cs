using System;
namespace Abstract_Factory_Pattern
{
    public class FemaleYellowHuman : AbstractYellowHuman
    {
        public override void getSex()
        {
            Console.WriteLine("黄色人种女性");
        }
    }
}