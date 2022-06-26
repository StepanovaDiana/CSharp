using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5;
using System.Drawing;

namespace RaceView
{
    class DrawingModel : DrawingObject
    {
        public Model Model { get; }

        public override float X { get => Model.posX; }
        public override float Y { get => Model.posY; }

        public DrawingModel(Model model, Image image)
            : base(image)
        {
            this.Model = model;
        }
    }
}
