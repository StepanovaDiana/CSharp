using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab5;

namespace RaceView
{
    
    class DrawingObject
    {
       
        public virtual float X { get; set; }
        public virtual float Y { get; set; }

        public Image Image { get; set; }

       
        public DrawingObject(Image image)
        {
            this.Image = image;
        }

        public DrawingObject(Image image, float x, float y)
        {
            this.Image = image;
            X = x;
            Y = y;
        }
    }
}
