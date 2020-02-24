using System;
namespace Observer_Pattern
{
    public class LiSi : ILiSi
    {
        //首先李斯是个观察者，一旦韩非子有活动，他就知道，他就要向老板汇报
        public void update(string str)
        {
            Console.WriteLine("李斯:观察到韩非子活动，开始向老板汇报了...");
            this.reportToQinShiHuang(str);
            Console.WriteLine("李斯：汇报完毕...\n");
        }
        //汇报给秦始皇
        private void reportToQinShiHuang(string reportContext)
        {
            Console.WriteLine("李斯：报告，秦老板！韩非子有活动了--->" + reportContext);
        }
    }
}