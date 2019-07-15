using System;
namespace Mediator_Pattern
{
    /// <summary>
    /// 中介者 处理各个逻辑
    /// </summary>
    public class Mediator : AbstractMediator
    {
        /// <summary>
        /// 根据 str 参数执行不同的方法
        /// </summary>
        /// <param name="str"></param>
        /// <param name="@object"></param>
        public override void execute(string str, object @object = null)
        {
            if (str.Equals("purchase.buy"))
            {
                buyComputer((int)@object);
            }
            else if (str.Equals("sale.sell"))
            {
                sellComputer((int)@object);
            }
            else if (str.Equals("sale.offsell"))
            {
                offSell();
            }
            else if (str.Equals("stock.clear"))
            {
                clearStock();
            }
        }

        /// <summary>
        /// 购买电脑
        /// </summary>
        /// <param name="number"></param>
        private void buyComputer(int number)
        {
            int saleStatus = base.sale.getSaleStatus();
            if (saleStatus > 80)
            {
                Console.WriteLine($"采购IBM电脑：{number} 台");
                base.stock.increase(number);
            }
            else
            {
                int buyNumber = number / 2;
                Console.WriteLine($"采购IBM电脑：{buyNumber} 台");
            }
        }

        /// <summary>
        /// 销售电脑
        /// </summary>
        /// <param name="number"></param>
        private void sellComputer(int number)
        {
            if (base.stock.getStockNumber() < number)
            {
                base.purchase.buyIBMComputer(number);
            }
            base.stock.decrease(number);
        }

        /// <summary>
        /// 促销
        /// </summary>
        private void offSell()
        {
            Console.WriteLine($"折价销售IBM电脑：{base.stock.getStockNumber()} 台");
        }

        /// <summary>
        /// 清理库存
        /// </summary>
        private void clearStock()
        {
            base.sale.offSale();
            base.purchase.refuseBuyIBM();
        }
    }
}