using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsitLab3.Entities;
using IsitLab3.Entities.Layers;
using static System.Math;
using static System.Console;

namespace IsitLab3.Entities
{
    public class Network
    {
        InputLayer input_layer = new InputLayer();
        public HiddenLayer hidden_layer = new HiddenLayer(9, 3, Enums.NeuronType.Hidden, nameof(hidden_layer));
        public OutputLayer output_layer = new OutputLayer(2, 9, Enums.NeuronType.Output, nameof(output_layer));
        public double[] fact = new double[2];

        double GetMSE(double[] errors)
        {
            double sum = 0;
            for (int i = 0; i < errors.Length; ++i)
                sum += Pow(errors[i], 2);
            return 0.5d * sum;
        }

        double GetCost(double[] mses)
        {
            double sum = 0;
            for (int i = 0; i < mses.Length; ++i)
                sum += mses[i];
            return (sum / mses.Length);
        }
        public static void Train(Network net)
        {
            const double threshold = 0.001d;//порог ошибки
            double[] temp_mses = new double[9];//массив для хранения ошибок итераций
            double temp_cost = 0;//текущее значение ошибки по эпохе
            do
            {
                for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
                {
                    net.hidden_layer.Data = net.input_layer.Trainset[i].Item1;
                    net.hidden_layer.Recognize(null, net.output_layer);
                    net.output_layer.Recognize(net, null);
                    //вычисление ошибки по итерации
                    double[] errors = new double[net.input_layer.Trainset[i].Item2.Length];
                    for (int x = 0; x < errors.Length; ++x)
                        errors[x] = net.input_layer.Trainset[i].Item2[x] - net.fact[x];
                    temp_mses[i] = net.GetMSE(errors);
                    double[] temp_gsums = net.output_layer.BackwardPass(errors);
                    net.hidden_layer.BackwardPass(temp_gsums);
                }
                temp_cost = net.GetCost(temp_mses);//вычисление ошибки по эпохе
                Console.WriteLine($"{temp_cost}");
            } while (temp_cost > threshold);
            net.hidden_layer.WeightInitialize(Enums.MemoryMode.SET, nameof(hidden_layer));
            net.output_layer.WeightInitialize(Enums.MemoryMode.SET, nameof(output_layer));
        }

        public static void Test(Network net)
        {
            for (int i = 0; i < net.input_layer.Trainset.Length; ++i)
            {
                net.hidden_layer.Data = net.input_layer.Trainset[i].Item1;
                net.hidden_layer.Recognize(null, net.output_layer);
                net.output_layer.Recognize(net, null);
                for (int j = 0; j < net.fact.Length; ++j)
                WriteLine();
            }
        }
    }
}
