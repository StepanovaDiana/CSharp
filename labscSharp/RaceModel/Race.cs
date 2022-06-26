using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5
{

    public class Race : Model
    {
       
        private readonly List<Car> cars;
        private readonly object carsLocker;

       
        List<Car> participatingCars;

        const int maxParticipatingCarsNumber = 10;

        public Race(Action<string> msg, List<Car> cars, object carsLocker,
            float x, float y)
            : base(msg)
        {
            this.cars = cars;
            this.carsLocker = carsLocker;
            posX = x;
            posY = y;

            participatingCars = new List<Car>();
        }

       
        bool StartCompetition()
        {
            participatingCars.Clear();

            lock (carsLocker)
            {
                int participatingCarsNumber = 0;

                for (int i = 0; i < cars.Count && participatingCarsNumber < maxParticipatingCarsNumber; i++)
                {
                   
                    if (!cars[i].IsLocked)
                    {
                        
                        cars[i].ToX = posX;
                        cars[i].ToY = posY;

                        cars[i].IsLocked = true;
                        participatingCars.Add(cars[i]);

                        participatingCarsNumber++;
                    }
                }
            }

            return participatingCars.Count != 0;
        }

       
        void WaitAllCars()
        {
            bool allCarsCame = false; ;

            while (!allCarsCame)
            {
                Task.Delay(100).Wait();

                lock (carsLocker)
                {
                    allCarsCame = participatingCars.FirstOrDefault(item =>
                    !item.IsCome()) == null;
                }
            }
        }


        void DoRace()
        {
            Message($"В гонке примут участие {participatingCars.Count} машин");
            WaitAllCars();

            Message($"Гонка начинается");
            Message($"Гонка продолжается");
            
            Task.Delay(5 * 1000).Wait();
        }

   
        void PrintWarnTyreCar(Car car)
        {
            Message($"У {car.Name} стерлись покрышки, он заехал в бокс!");
        }

       
        int getNextWarnTyre(Random random, int participatingCarsNumber, List<int> WarnTyre)
        {
            int result;

            do
            {
                result = random.Next(0, participatingCarsNumber);
            }
            while (WarnTyre.Contains(result)); 

            return result;
        }

       
        List<int> DetermineWarnTyre()
        {
            List<int> WarnTyre = new List<int>();

            Message($"Случился прожог шин!");

            Random random = new Random();

            int howMuchWarnTyreCars = random.Next(0, participatingCars.Count / 2);
            if (howMuchWarnTyreCars == 0)
                return WarnTyre;

            for(int i = 0; i < howMuchWarnTyreCars; ++i)
            {
                int warnTyreCar = getNextWarnTyre(random, participatingCars.Count, WarnTyre);
                WarnTyre.Add(warnTyreCar);
                PrintWarnTyreCar(participatingCars[warnTyreCar]);
            }

            return WarnTyre;
        }

       
        void WaitLoader(List<Car> crashCars)
        {
            bool allRepair = true;

            do
            {
                Task.Delay(100).Wait();

                allRepair = crashCars.Count(car => car.IsCrash) == 0;

            } while (!allRepair);
        }

       
        void PrintCrashCars(List<Car> crashCars)
        {
            string message = "";

            foreach (var item in crashCars)
            {
                message += $"{item.Name} – врезался\r\n";
            }

            Message(message);
        }

       
        List<Car> DetermineCrashCars(List<int> warnTyre)
        {
            List<Car> crashCars = new List<Car>();

            Random random = new Random();

            for (int i = 0; i < participatingCars.Count; i++)
                if (!warnTyre.Contains(i))
                {
                    participatingCars[i].RandomCrash(random);

                    if (participatingCars[i].IsCrash)
                        crashCars.Add(participatingCars[i]);
                    else
                        participatingCars[i].IsLocked = false;
                }

            return crashCars;
        }

        public void EndCompetition()
        {
            Message($"Гонка закончилась");

            List<int> warnTyre = DetermineWarnTyre();


            foreach (var item in warnTyre)
            {
                participatingCars[item].IsLocked = false;
            }
                        

            Random random = new Random();

            List<Car> crashCars = DetermineCrashCars(warnTyre);

            if (crashCars.Count != 0)
            {
                Message($"Во время гонки машины столкнулись\n");

                PrintCrashCars(crashCars);
                Message($"Пока все болиды не отремонтируют, соревнование не начнётся");
                WaitLoader(crashCars);

                Message($"Гонка : Все машины отремонтированы!");
            }
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                Message($"Скоро начнется гонка ");

                Task.Delay(1 * 1000).Wait();

                if (!StartCompetition())
                {
                    Message($"Болиды не приехали на участие, гонка отменяется");
                }
                else
                {
                    DoRace();

                    EndCompetition();   
                }

                
                Task.Delay(3 * 1000).Wait();
            }
        }
    }
}
