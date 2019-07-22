using System;

namespace Factory_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 工厂模式
            Console.WriteLine("----------工厂模式---------");
            AbstractHumanFactory<IHuman> humanFactory = new HumanFactory<IHuman>();
            var chinese = humanFactory.CreateHuman("YellowHuman");
            chinese.GetColor();
            chinese.Talk();

            var african = humanFactory.CreateHuman("BlackHuman");
            african.GetColor();
            african.Talk();

            var american = humanFactory.CreateHuman("WhiteHuman");
            american.GetColor();
            american.Talk();
            #endregion
            #region 简单工厂模式调用
            Console.WriteLine("----------简单工厂模式---------");
            chinese = SimpleHumanFactory<IHuman>.CreateHuman("YellowHuman");
            chinese.GetColor();
            chinese.Talk();

            african = SimpleHumanFactory<IHuman>.CreateHuman("BlackHuman");
            african.GetColor();
            african.Talk();

            american = SimpleHumanFactory<IHuman>.CreateHuman("WhiteHuman");
            american.GetColor();
            american.Talk();
            #endregion
        }
    }
}
