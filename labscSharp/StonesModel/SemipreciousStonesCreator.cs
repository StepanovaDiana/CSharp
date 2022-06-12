using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
    class SemipreciousStonesCreator: Creator
    {
        public override Stones FactoryMethod(string stonesName, double stonesWeight, double stonesPrice, double stonesTransparencyParameter)
        {
            return new SemipreciousStones(stonesName, stonesWeight, stonesPrice, stonesTransparencyParameter);
        }
    }
}
