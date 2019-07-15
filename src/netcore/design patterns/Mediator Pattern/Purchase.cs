using System;
namespace Mediator_Pattern
{
    /// <summary>
    /// 采购员
    /// </summary>
    public class Purchase : AbstractColeague
    {
        public Purchase(AbstractMediator mediator) : base(mediator)
        {

        }

        /// <summary>
        /// 买电脑
        /// </summary>
        /// <param name="number">买电脑的数量</param>
        public void buyIBMComputer(int number)
        {
            base.mediator.execute("purchase.buy", number);
        }

        /// <summary>
        /// 停止买电脑
        /// </summary>
        public void refuseBuyIBM()
        {
            Console.WriteLine("不再采购IBM电脑");
        }
    }
}