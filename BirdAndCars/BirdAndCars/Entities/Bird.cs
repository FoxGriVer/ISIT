using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndCars.Entities
{
    public class Bird
    {
        public double Speed { get; set; }
        public double SumDistance { get; set; }

        public Bird(double speed)
        {
            Speed = speed;
        }
    }
}
