using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClassDesign
{
    class Stats
    {
        int brawn, speed, wit, spirit, finesse;

        public Stats(int brawn, int speed, int wit, int spirit, int finesse)
        {
            this.brawn = brawn;
            this.speed = speed;
            this.wit = wit;
            this.spirit = spirit;
            this.finesse = finesse;
        }

        public int Brawn { get => brawn; set => brawn = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Wit { get => wit; set => wit = value; }
        public int Spirit { get => spirit; set => spirit = value; }
        public int Finesse { get => finesse; set => finesse = value; }

        public override string ToString()
        {
            return "Your character has "+ brawn+ " brawn, " + speed+" speed, "+wit+" wit, "+spirit+" spirit, and "+finesse+" finesse.";
        }
    }
}
