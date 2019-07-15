namespace Mediator_Pattern
{
    /// <summary>
    /// 被中介者管理的三者之间关系
    /// </summary>
    public abstract class AbstractColeague
    {
        /// <summary>
        /// 中介
        /// </summary>
        protected AbstractMediator mediator;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="_mediator">中介</param>
        public AbstractColeague(AbstractMediator _mediator)
        {
            mediator = _mediator;
        }
    }
}