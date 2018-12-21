using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsitLab3.Entities;

namespace IsitLab3.Entities.Layers
{
    public class InputLayer
    {
        private (double[], double[])[] _trainset = new (double[], double[])[]
        {                   
            (new double[]{ 1, 1, 0 }, new double[]{ 0, 1 }),
            (new double[]{ 1, 0, 1 }, new double[]{ 1, 0}),
            (new double[]{ 0, 1, 1 }, new double[]{ 1, 0 }),
            (new double[]{ 0, 1, 0 }, new double[]{ 0, 1 }),
            (new double[]{ 0, 1, 1 }, new double[]{ 1, 1 }),
            (new double[]{ 0, 0, 1 }, new double[]{ 0, 0 }),
            (new double[]{ 0, 1, 0 }, new double[]{ 0, 1 }),
            (new double[]{ 1, 1, 1 }, new double[]{ 1, 0 }),
            (new double[]{ 0, 0, 0 }, new double[]{ 1, 0 })
        };

        public (double[], double[])[] Trainset { get => _trainset; }
    }
}
