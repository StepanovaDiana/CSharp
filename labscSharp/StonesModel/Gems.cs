using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
   public  class Gems:Stones
   {
     

        public Gems(string stonesName, double stonesWeight=0.1, double stonesPrice=2000, double stonesTransparencyParameter=80)
        {
            Name = stonesName;
            Weight = stonesWeight;
            Price = stonesPrice;
            TransparencyParameter = stonesTransparencyParameter;
        }
    }
}
