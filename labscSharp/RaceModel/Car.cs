using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Car : MoveModel
    {
        public bool IsCrash { get; internal set; }

        public Car(Action<string> msg, float defaultX, float defaultY)
            : base(msg, defaultX, defaultY)
        {

        }
        public bool WaitLoader { get; internal set; }
        public bool WaitRepair { get; internal set; }

        public void RandomCrash(Random random)
        {   
            
            if (random.Next(0, 10) < 4)
            {
                IsCrash = true;
                WaitLoader = false;
                WaitRepair = false;
            }
        }

        
        protected override void Check()
        {
            if (!IsLocked)
            {
                ToX = defaultX;
                ToY = defaultY;
            }
        }
    }
}
