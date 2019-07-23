namespace Abstract_Factory_Pattern
{
    public class FemaleFactory : IHumanFactory
    {
        public IHuman createBlackHuman()
        {
            return new FemaleBlackHuman();
        }

        public IHuman createWhiteHuman()
        {
            return new FemaleWhiteHuman();
        }

        public IHuman createYellowHuman()
        {
            return new FemaleYellowHuman();
        }
    }
}