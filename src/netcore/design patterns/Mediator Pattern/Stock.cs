using System;

namespace Mediator_Pattern
{
    /// <summary>
    /// 库存
    /// </summary>
    public class Stock : AbstractColeague
    {
        private static int Computer_Number = 100;
        public Stock(AbstractMediator _mediator) : base(_mediator)
        {
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="number"></param>
        public void increase(int number)
        {
            Computer_Number += number;
            Console.WriteLine($"库存的数量为: {Computer_Number}");
        }

        /// <summary>
        /// 出货
        /// </summary>
        /// <param name="number"></param>
        public void decrease(int number)
        {
            Computer_Number -= number;
            Console.WriteLine($"库存的数量为: {Computer_Number}");
        }

        /// <summary>
        /// 获取库存量
        /// </summary>
        /// <returns></returns>
        public int getStockNumber()
        {
            return Computer_Number;
        }

        /// <summary>
        /// 清空库存量
        /// </summary>
        public void clearStock()
        {
            Console.WriteLine($"清理存货数量为：{Computer_Number}");
            base.mediator.execute("stock.clear");
        }
    }
}