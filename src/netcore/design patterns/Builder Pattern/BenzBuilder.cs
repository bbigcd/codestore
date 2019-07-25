using System.Collections.Generic;

namespace Builder_Pattern
{
    public class BenzBuilder : CarBuilder
    {
        private BenzModel benz = new BenzModel();
        public override CarModel getCarModel()
        {
            return benz;
        }

        public override void setSequence(List<string> sequence)
        {
            benz.setSequence(sequence);
        }
    }
}