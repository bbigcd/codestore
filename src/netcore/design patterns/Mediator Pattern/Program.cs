using System;

namespace Mediator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.kancloud.cn/sstd521/design/193549

            AbstractMediator mediator = new Mediator();

            //采购人员采购电脑
            Console.WriteLine("------采购人员采购电脑--------");
            Purchase purchase = new Purchase(mediator);
            purchase.buyIBMComputer(100);


            //销售人员销售电脑
            Console.WriteLine("\n------销售人员销售电脑--------");
            Sale sale = new Sale(mediator);
            sale.sellIBMComputer(1);


            //库房管理人员管理库存
            Console.WriteLine("\n------库房管理人员清库处理--------");
            Stock stock = new Stock(mediator);
            stock.clearStock();
        }
    }
}
