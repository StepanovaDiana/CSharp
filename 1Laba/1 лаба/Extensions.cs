using System;
using System.Collections.Generic;
using System.Text;

namespace _1_лаба
{
    public static class Extensions
    {
        public static void ShowItems(this IDecorations necklace)
        {
            Console.WriteLine("Камни : ");
            foreach (var i in necklace.Items)
            {
                Console.WriteLine("Название камня: {0}, Вес камня: {1}, Цена: {2}, Прозрачность: {3},"
                    , i.Name, i.Weight, i.Price, i.TransparencyParameter);

            }

        }
    }
}
