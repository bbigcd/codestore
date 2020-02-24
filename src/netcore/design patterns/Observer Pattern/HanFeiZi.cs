using System;
namespace Observer_Pattern
{
    public class HanFeiZi : IHanFeiZi
    {
        //韩非子是否在吃饭，作为监控的判断标准
        public bool isHavingBreakfast { get; set; } = false;
        //韩非子是否在娱乐
        public bool isHavingFun { get; set; } = false;
        //韩非子要吃饭了
        public void haveBreakfast()
        {
            Console.WriteLine("韩非子:开始吃饭了...");
            this.isHavingBreakfast = true;
        }
        //韩非子开始娱乐了
        public void haveFun()
        {
            Console.WriteLine("韩非子:开始娱乐了...");
            this.isHavingFun = true;
        }

    }
}