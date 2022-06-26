using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Mechanic : MoveModel
    {
        private readonly List<Car> cars;
        private readonly object carsLocker;

      
        public Car crashCar;

        public Mechanic(Action<string> msg, float defaultX, float defaultY, List<Car> cars, object carsLocker)
            : base(msg, defaultX, defaultY)
        {
            this.cars = cars;
            this.carsLocker = carsLocker;
        }
                
       
        public void Repair()
        {
            Message($"Механик {Name} чинит машину " +
                    $"{crashCar.Name}");
            
            crashCar.WaitRepair = true;
            Task.Delay(3 * 1000).Wait();

            crashCar.IsCrash = false;
            crashCar.IsLocked = false;

            Message($"Болид {crashCar.Name} отремонтирован");
            

            
            DoSomething = null;
            IsLocked = false;
        }

        protected override void Check()
        {
            
        }
    }
}