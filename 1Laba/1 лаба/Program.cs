using System;
using System.Collections.Generic;
namespace _1_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new GemsCreator();
            creators[1] = new SemipreciousStonesCreator();

            IDecorations necklace = new Necklace();

            foreach (Creator i in creators)
            {
                if (i is GemsCreator)
                {
                    necklace.Add(i.FactoryMethod("Алмаз", 0.02, 26000.98, 87));
                    necklace.Add(i.FactoryMethod("Сапфир", 0.05, 15000.23, 76));
                }

                if (i is SemipreciousStonesCreator)
                {
                    necklace.Add(i.FactoryMethod("Лазурит", 1.5, 120, 25));
                    necklace.Add(i.FactoryMethod("Глауконит", 1.0, 1.8, 28));
                }
            }

            necklace.Sort();
            necklace.ShowItems();

            Console.WriteLine();
            foreach (var items in necklace.FindNecklaceByTransparencyParameter(20, 80))
            {
                Console.WriteLine("Название камня: {0}, Прозрачность: {1}", items.Name, items.TransparencyParameter);
            }

            Console.WriteLine();
            Console.WriteLine("Вес ожерелья: {0}, Стоимость: {1}",necklace.NecklaceWeight(),necklace.NecklacePrice());
            Console.ReadKey();
        }
        
    }
}
