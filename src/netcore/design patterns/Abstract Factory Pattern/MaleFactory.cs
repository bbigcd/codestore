namespace Abstract_Factory_Pattern
{
    public class MaleFactory : IHumanFactory
    {
        public IHuman createBlackHuman()
        {
            return new MaleBlackHuman();
        }

        public IHuman createWhiteHuman()
        {
            return new MaleWhiteHuman();
        }

        public IHuman createYellowHuman()
        {
            return new MaleYellowHuman();
        }
    }
}