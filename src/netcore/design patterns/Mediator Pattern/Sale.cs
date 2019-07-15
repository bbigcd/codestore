using System;
namespace Mediator_Pattern
{
    /// <summary>
    /// 销售员
    /// </summary>
    public class Sale : AbstractColeague
    {
        public Sale(AbstractMediator _mediator) : base(_mediator)
        {
        }

        /// <summary>
        /// 销售电脑
        /// </summary>
        /// <param name="number">销售电脑的数量</param>
        public void sellIBMComputer(int number)
        {
            base.mediator.execute("sale.sell", number);
            Console.WriteLine($"销售IBM电脑 {number} 台");
        }

        /// <summary>
        /// 获取销售情况
        /// </summary>
        /// <returns></returns>
        public int getSaleStatus()
        {
            Random rand = new Random();
            int saleStatus = rand.Next(0, 100);
            Console.WriteLine($"IBM电脑的销售情况为：{saleStatus}");
            return saleStatus;
        }

        /// <summary>
        /// 停止销售
        /// </summary>
        public void offSale()
        {
            base.mediator.execute("sale.offsell", null);
        }
    }
}