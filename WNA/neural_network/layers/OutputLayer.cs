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
    public class OutputLayer : Layer<OutputNeuron>
    {
        public OutputLayer(int neuronsCount, IActivationFunction func) : base(neuronsCount, 0, func)
        {
            for (int i = 0; i < neuronsCount; i++)
            {
                neurons.Add(new OutputNeuron());
            }
        }

        public override double[] GetOutputVector(double[] inputs, out double[] neuronsOutput)
        {
            return neuronsOutput = CalculateOutput(inputs);
        }

        //эталон минус то что получилось, умножить на производную функции активации в точке входа выходного слоя
        internal IEnumerable<double> Train(double[] outputVector, double[] learnOutput, double[] layerInput)
        {
            double[] error = new double[neurons.Count];
            for (int i = 0; i < neurons.Count; i++)
            {
                yield return error[i] = (learnOutput[i] - outputVector[i]) * neurons[i].GetDerivative(layerInput[i], function);
            }
        }
    }
}
