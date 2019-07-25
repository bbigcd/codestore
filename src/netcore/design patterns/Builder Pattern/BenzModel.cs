using System;

namespace Builder_Pattern
{
    public class BenzModel : CarModel
    {
        protected override void alarm()
        {
            Console.WriteLine("奔驰车的喇叭声音是这个样子的...");
        }
        protected override void engineBoom()
        {
            Console.WriteLine("奔驰车的引擎是这个声音的...");
        }
        protected override void start()
        {
            Console.WriteLine("奔驰车跑起来是这个样子的...");
        }
        protected override void stop()
        {
            Console.WriteLine("奔驰车应该这样停车...");
        }
    }
}