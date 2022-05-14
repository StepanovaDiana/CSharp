using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Class1 : Meeting
    {
        int NumberOfGroup;


        public double Quality() => NumberOfSpeakers / NumberOfParticipant;

        public override double Q() => Quality() + NumberOfGroup / NumberOfParticipant;


        public Class1(string name, int numberSpeakers, int numberParticipant, int numberGroup)
            : base(name, numberSpeakers, numberParticipant)
        {
            NumberOfGroup = numberGroup;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Число групп ораторов, которые 	высказывали одинаковые мысли : " + NumberOfGroup;
        }
        public int numberOfGroup { get { return NumberOfGroup; } set { NumberOfGroup = value; } }
    }
}
