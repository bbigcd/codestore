using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一条生产线，男性生产线
            IHumanFactory maleHumanFactory = new MaleFactory();
            //第二条生产线，女性生产线
            IHumanFactory femaleHumanFactory = new FemaleFactory();
            //生产线建立完毕，开始生产人了:
            IHuman maleYellowHuman = maleHumanFactory.createYellowHuman();
            IHuman femaleYellowHuman = femaleHumanFactory.createYellowHuman();
            Console.WriteLine("---生产一个黄色女性---");
            femaleYellowHuman.getColor();
            femaleYellowHuman.talk();
            femaleYellowHuman.getSex();
            Console.WriteLine("\n---生产一个黄色男性---");
            maleYellowHuman.getColor();
            maleYellowHuman.talk();
            maleYellowHuman.getSex();
        }
    }
}
