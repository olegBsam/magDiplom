using MathHelper.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNA.neural_network.neurons;

namespace WNA.neural_network.layers
{
    [Serializable]
    public abstract class Layer<T> where T : AbstractNeuron
    {
        protected IFunction function;
        protected List<T> neurons = new List<T>();
        protected int size;
        protected int nextLayerSize;

        protected Layer(int neuronsCount, int nextLayerSize, IFunction func)
        {
            this.size = neuronsCount;
            this.nextLayerSize = nextLayerSize;
            this.function = func;
        }

        /// <summary>
        /// Возвращает сигнал на входе следующего слоя.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="neuronsOutput">Сигнал на выходе слоя.</param>
        /// <returns></returns>
        public abstract double[] GetOutputVector(double[] inputs, out double[] neuronsOutput);

        protected virtual double[] CalculateOutput(double[] inputs)
        {
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = neurons[i].GetOutput(inputs[i], function);
            }
            return result;
        }
    }
}
