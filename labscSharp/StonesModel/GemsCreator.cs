using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
    public class GemsCreator : Creator
    {
        public override Stones FactoryMethod(string stonesName, double stonesWeight, double stonesPrice, double stonesTransparencyParameter)
        {
            return new Gems(stonesName, stonesWeight, stonesPrice, stonesTransparencyParameter);
        }
    }
}
