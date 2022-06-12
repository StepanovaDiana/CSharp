using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
      public class  SemipreciousStones :Stones
      {
          public SemipreciousStones(string stonesName, double stonesWeight=0.1, double stonesPrice=78, double stonesTransparencyParameter=25)
          {
            Name = stonesName;
            Weight = stonesWeight;
            Price = stonesPrice;
            TransparencyParameter = stonesTransparencyParameter;
          }

      }
}
