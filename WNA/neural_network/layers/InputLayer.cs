using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNA.neural_network.neurons;

namespace WNA.neural_network.layers
{
    [Serializable]
    public class InputLayer : LayerWithWeight
    {
        public InputLayer(int neuronsCount, int nextLayerSize) : base(neuronsCount, nextLayerSize, null)
        {
            for (int i = 0; i < neuronsCount; i++)
            {
                neurons.Add(new InputNeuron(nextLayerSize));
            }
        }
    }
}
