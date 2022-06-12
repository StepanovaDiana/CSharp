using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
    public abstract class Creator
    {
        public abstract Stones FactoryMethod(string stonesName, double stonesWeight, double  stonesPrice, double stonesTransparencyParameter);
    }
}
