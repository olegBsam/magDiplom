using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNA.neural_network.neurons
{
    [Serializable]
    public class OffsetNeuron : AbstractNeuronWithWeight
    {
        const int OFFSET = 1;

        public OffsetNeuron(int linkCount) : base(linkCount) {}

        public override double GetOutput(double input)
        {
            return OFFSET;
        }
    }
}
