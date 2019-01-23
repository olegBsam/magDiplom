using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public class HiddenNeuron : AbstractNeuronWithWeight
    {
        public HiddenNeuron(int linkCount) : base(linkCount) {}
    }
}
