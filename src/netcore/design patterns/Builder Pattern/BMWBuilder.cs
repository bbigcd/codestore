using System.Collections.Generic;

namespace Builder_Pattern
{
    public class BMWBuilder : CarBuilder
    {
        private BMWModel bmw = new BMWModel();
        public override CarModel getCarModel()
        {
            return bmw;
        }

        public override void setSequence(List<string> sequence)
        {
            bmw.setSequence(sequence);
        }
    }
}