using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
   
    public abstract class Loader : MoveModel, ILoader
    {
        
        private readonly List<Car> cars;
        private readonly object carsLocker;

      
        Car crashCar;

        
        List<Mechanic> mechanics;
        object lockerMechanics;

        public Loader(Action<string> msg, float defaultX, float defaultY, List<Car> cars, object carsLocker, List<Mechanic>mechanics, object lockerMech)
            : base(msg, defaultX, defaultY)
        {
            this.cars = cars;
            this.carsLocker = carsLocker;
            this.lockerMechanics = lockerMech;
            this.mechanics = mechanics;
        }


        
        void Load()
        {
            if (IsCome())
            {
                Message($"Погрузчик {Name} погружает болид " +
                        $"{crashCar.Name}");

                Task.Delay(5 * 1000).Wait();

                ToX = defaultX; ToY = defaultY;
                crashCar.ToX = defaultX; crashCar.ToY = defaultY;
                DoSomething = BringToMechanic;
            }
        }

        
        void BringToMechanic()
        {
            if (IsCome())
            {
                lock (lockerMechanics)
                {
                    var mechan = mechanics.FirstOrDefault(mech => !mech.IsLocked);
                    if (mechan != null)
                    {
                        mechan.IsLocked = true;
                        mechan.crashCar = crashCar;
                        mechan.DoSomething = mechan.Repair;
                        IsLocked = false;
                        DoSomething = null;
                        
                        crashCar.WaitRepair = true;
                        crashCar = null;
                    }
                }
            }
        }

      
        protected override void Check()
        {
            if (IsLocked)
                return;

            lock(carsLocker)
            {
                crashCar = cars
                    .FirstOrDefault(sportsman => sportsman.IsCrash && !sportsman.WaitLoader && !sportsman.WaitRepair);

                if (crashCar != null)
                {
                   
                    crashCar.WaitLoader = true;
                    ToX = crashCar.posX;
                    ToY = crashCar.posY;

                    IsLocked = true;
                    DoSomething = Load;

                    Message($"Погрузчик {Name} пошёл погружать болид " +
                        $"{crashCar.Name}");
                }
            }
        }
    }
}