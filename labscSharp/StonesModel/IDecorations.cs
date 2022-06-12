using System;
using System.Collections.Generic;
using System.Text;


namespace _1_лаба
{
    public interface IDecorations
    {
        IEnumerable<Stones> Items { get; }
        void Add(Stones stones);
        double NecklaceWeight();
        double NecklacePrice();
        void Sort();
        IEnumerable<Stones> FindNecklaceByTransparencyParameter(int min, int max);

    }

}
