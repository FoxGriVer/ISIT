using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAndCars.Entities
{
    public class Car
    {
        public double Speed { get; set; }

        public Car(double speed)
        {
            Speed = speed;
        }
    }
}
