namespace Abstract_Factory_Pattern
{
    public interface IHumanFactory
    {
        //制造一个黄色人种
        IHuman createYellowHuman();
        //制造一个白色人种
        IHuman createWhiteHuman();
        //制造一个黑色人种
        IHuman createBlackHuman();
    }
}