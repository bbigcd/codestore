using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义出韩非子和李斯
            // LiSi liSi = new LiSi();
            // HanFeiZi hanFeiZi = new HanFeiZi();
            // //观察早餐
            // Watch watchBreakfast = new Watch(hanFeiZi, liSi, "breakfast");
            // //开始启动线程，监控
            // watchBreakfast.start();
            // //观察娱乐情况
            // Watch watchFun = new Watch(hanFeiZi, liSi, "fun");
            // watchFun.start();
            // //然后我们看看韩非子在干什么
            // Thread.sleep(1000); //主线程等待1秒后后再往下执行
            // hanFeiZi.haveBreakfast();
            // //韩非子娱乐了
            // Thread.sleep(1000);
            // hanFeiZi.haveFun();
            var person = new Person();
            person.FallsIll += OnFallsIll;
            person.OnFallsIll();

        }

        private static void OnFallsIll(object sender, FallsIllEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
    }
}
