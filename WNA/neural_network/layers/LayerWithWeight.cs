using MathHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNA.neural_network.neurons;

namespace WNA.neural_network.layers
{
    [Serializable]
    public class LayerWithWeight : Layer<AbstractNeuronWithWeight>
    {
        protected LayerWithWeight(int neuronsCount, int nextLayerSize) : base(neuronsCount, nextLayerSize)
        {
            neurons.Add(new OffsetNeuron(nextLayerSize));
            this.size++;
        }

        /// <summary>
        /// Возвращает сигналы на входе следующего слоя.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="outputs">Сигнал на выходе слоя.</param>
        /// <returns></returns>
        public override double[] GetOutputVector(double[] inputs, out double[] outputs)
        {
            double[] neuronsOutput = CalculateOutput(inputs);
            double[] preparedSignal = new double[nextLayerSize];

            Extends.For(nextLayerSize, neuronsOutput.Length, (i, j) =>
            {
                preparedSignal[i] += neuronsOutput[j] * neurons[j].Weights[i];
            });

            outputs = neuronsOutput;
            return preparedSignal;
        }

        

        protected override double[] CalculateOutput(double[] inputs)
        {
            double[] result = new double[inputs.Length + 1];

            result[0] = neurons[0].GetOutput(1);//нейрон смещения 

            for (int i = 1; i < result.Length; i++)
            {
                result[i] = neurons[i].GetOutput(inputs[i - 1]);
            }
            return result;
        }

        internal void LearnLayer(double[][] correct, double moment)
        {
            for (int i = 0; i < correct.Length; i++)
            {
                for (int j = 0; j < neurons[i].Weights.Length; j++)
                {
                    //neurons[i].c += correct[i][j];
                    //neurons[i].r += correct[i][j];

                    neurons[i].Weights[j] += correct[i][j] + neurons[i].LastWeightCorrect[j] * moment;
                    neurons[i].LastWeightCorrect[j] = correct[i][j];
                }
            }
        }
    }
}
