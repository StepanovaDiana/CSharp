using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Loader1 : Loader
    {
        public Loader1(Action<string> msg, float defaultX, float defaultY, List<Car> cars, object carsLocker, List<Mechanic> mechanics, object lockerMech)
            : base(msg, defaultX, defaultY, cars, carsLocker,mechanics, lockerMech)
        {
            
        }
    }
}
