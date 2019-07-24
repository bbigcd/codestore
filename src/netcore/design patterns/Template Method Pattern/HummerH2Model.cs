using System;

namespace Template_Method_Pattern
{
    public class HummerH2Model : HummerModel
    {
        //H2型号的悍马车鸣笛
        public override void alarm()
        {
            Console.WriteLine("悍马H2鸣笛...");
        }
        //引擎轰鸣声
        public override void engineBoom()
        {
            Console.WriteLine("悍马H2引擎声音是这样在...");
        }
        //汽车发动
        public override void start()
        {
            Console.WriteLine("悍马H2发动...");
        }
        //停车
        public override void stop()
        {
            Console.WriteLine("悍马H2停车...");
        }
    }
}