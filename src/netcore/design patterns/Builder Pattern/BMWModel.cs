using System;

namespace Builder_Pattern
{
    public class BMWModel : CarModel
    {
        protected override void alarm()
        {
            Console.WriteLine("宝马的喇叭声音是这个样子的...");
        }
        protected override void engineBoom()
        {
            Console.WriteLine("宝马的引擎是这个声音的...");
        }
        protected override void start()
        {
            Console.WriteLine("宝马跑起来是这个样子的...");
        }
        protected override void stop()
        {
            Console.WriteLine("宝马应该这样停车...");
        }
    }
}