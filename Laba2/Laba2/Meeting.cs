using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Meeting
    {
        public string Name;
        public int NumberOfSpeakers;
        public int NumberOfParticipant;
        public virtual double Q() => NumberOfSpeakers / NumberOfParticipant;


        public Meeting(string name, int numberSpeakers, int numberParticipant)
        {
            Name = name;
            NumberOfSpeakers = numberSpeakers;
            NumberOfParticipant = numberParticipant;
        }
        public virtual string ToString()
        {
            return "Название собития: " + Name + Environment.NewLine +
                "Число ораторов: " + NumberOfSpeakers + Environment.NewLine +
                "Число участников: " + NumberOfParticipant;
        }

        public string name { get { return Name; } set { Name = value; } }
        public int numberOfSpeakers { get { return NumberOfSpeakers; } set { NumberOfSpeakers = value; } }
        public int numberOfParticipant { get { return NumberOfParticipant; } set { NumberOfParticipant = value; } }

    }
}
