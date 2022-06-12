using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _1_лаба
{
       public class Necklace:IDecorations
       {

        private ICollection<Stones> items;
        public Necklace()
            {
            items = new List<Stones>();
        }

            public void Add(Stones stones)
            {
                items.Add(stones);
            }

            public double NecklaceWeight()
            {
                return items.Sum(x => x.Weight);

            }
            public double NecklacePrice()
            {
            return items.Sum(x => x.Price);

            }

            public void Sort() => items.OrderBy(x => x.Price);
            

            public IEnumerable<Stones> FindNecklaceByTransparencyParameter(int min, int max)
            {
                return items.Where(x => x.TransparencyParameter <= max && x.TransparencyParameter >= min).ToList();
            }

            public IEnumerable<Stones> Items
            {
                get { return this.items; }
            }
       }
    
}
