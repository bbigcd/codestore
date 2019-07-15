namespace Mediator_Pattern
{
    /// <summary>
    /// 中介者 - 抽象
    /// </summary>
    public abstract class AbstractMediator
    {
        // 采购
        protected Purchase purchase;
        // 销售
        protected Sale sale;
        // 库存
        protected Stock stock;

        /// <summary>
        /// 构造方法，包含三者的初始化，并将中介者通过各自的构造方法注入到各自其中
        /// </summary>
        public AbstractMediator()
        {
            purchase = new Purchase(this);
            sale = new Sale(this);
            stock = new Stock(this);
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="str">要执行的命令</param>
        /// <param name="@object">包含的对象</param>
        public abstract void execute(string str, object @object = null);
    }
}