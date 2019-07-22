namespace Factory_pattern
{
    public abstract class AbstractHumanFactory<T> where T : IHuman
    {
        public abstract T CreateHuman(string who);
    }
}