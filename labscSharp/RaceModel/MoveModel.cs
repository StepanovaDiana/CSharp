using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    public abstract class MoveModel : Model
    {
  
        public float defaultX, defaultY;

      
        public float ToX { get; internal set; }
        public float ToY { get; internal set; }

        public MoveModel(Action<string> msg, float defaultX, float defaultY)
            : base(msg)
        {
            this.defaultX = defaultX;
            this.defaultY = defaultY;

            posX = defaultX;
            posY = defaultY;

            ToX = defaultX;
            ToY = defaultY;
            
            DoSomething = null;
        }

        
        public string Name { get; set; }

        const float moveConst = 3;

      
        public Action DoSomething;

      
        protected abstract void Check();

       
        public bool IsCome()
        {
            return Math.Abs(posX - ToX) < 5 && Math.Abs(posY - ToY) < 5;
        }

        public void Move()
        {
            if (IsCome())
                return;

           
            if (posX - ToX != 0)
            {
                posY += moveConst * (ToY - posY) / Math.Abs(posX - ToX);
                posX += moveConst * Math.Sign(ToX - posX);
            }
            else
            {
                posX += moveConst * (ToX - posX) / Math.Abs(posY - ToY);
                posY += moveConst * Math.Sign(posY - ToY);
            }
        }

        
        public override void Start()
        {
            while (!IsCanceled)
            {
                Check();
                Move();

                DoSomething?.Invoke();

                Task.Delay(30).Wait();
            }
        }
    }
}
