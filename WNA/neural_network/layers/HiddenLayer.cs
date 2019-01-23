using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNA.neural_network.neurons;

namespace WNA.neural_network.layers
{
    [Serializable]
    public class HiddenLayer : LayerWithWeight
    {
        public HiddenLayer(int neuronsCount, int nextLayerSize) : base(neuronsCount, nextLayerSize)
        {
            for (int i = 0; i < neuronsCount; i++)
            {
                neurons.Add(new HiddenNeuron(nextLayerSize));
            }
        }

        internal double[] Train(double[] errorOnOutput, double[] layerInput)
        {
            double[] error = new double[neurons.Count];

            for (int i = 0; i < neurons.Count; i++)
            {   //ошибка умнож на вес (GetSumError) и умножается на произв от точки на входе нейрона скрыт слоя //
                error[i] = neurons[i].GetSumError(errorOnOutput) * neurons[i].GetDerivative(i < neurons.Count - 1 ? layerInput[i] : 1);
            }
            return error;
        }
    }
}
