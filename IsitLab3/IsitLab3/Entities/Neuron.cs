using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using IsitLab3.Entities.Layers;

namespace IsitLab3.Entities
{
    public class Neuron
    {
        public Enums.NeuronType Type { get; set; }
        public double[] Weights { get; set; }
        public double[] Inputs { get; set; }
        public double Output { get => Activator(Inputs, Weights); }

        public Neuron(double[] inputs, double[] weights, Enums.NeuronType type)
        {
            Type = type;
            Weights = weights;
            Inputs = inputs;
        }

        private double Activator(double[] value, double[] weight)
        {
            double sum = 0;
            for (int l = 0; l < value.Length; ++l)
                sum += value[l] * weight[l];
            return Pow(1 + Exp(-sum), -1);
        }

        public double Derivativator(double outsignal) => outsignal * (1 - outsignal);

        public double Gradientor(double error, double dif, double g_sum) => (Type == Enums.NeuronType.Output) ? error * dif : g_sum * dif;
    }
}
