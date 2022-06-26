using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public abstract class Model
    {
       
        public float posX { get; internal set; }
        public float posY { get; internal set; }

        
        public bool IsLocked { get; internal set; }
        
        
        public bool IsCanceled { get; set; }

       
        public abstract void Start();

      
        public Action<string> Message;

        public Model(Action<string> msg)
        {
            this.Message = msg;
        }
    }
}
