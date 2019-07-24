using System;
namespace Template_Method_Pattern
{
    public class HummerH1Model : HummerModel
    {
        //H1型号的悍马车鸣笛
        public override void alarm()
        {
            Console.WriteLine("悍马H1鸣笛...");
        }
        //引擎轰鸣声
        public override void engineBoom()
        {
            Console.WriteLine("悍马H1引擎声音是这样的...");
        }
        //汽车发动
        public override void start()
        {
            Console.WriteLine("悍马H1发动...");
        }
        //停车
        public override void stop()
        {
            Console.WriteLine("悍马H1停车...");
        }
    }
}