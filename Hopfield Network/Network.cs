using System.Runtime.InteropServices;

namespace Hopfield_Network
{
    internal class Network
    {
        Neuron[] neuron = new Neuron[4];
        int[] output = new int[4];

        public Network(int[] w1, int[] w2, int[] w3, int[] w4)
        {
            neuron[0] = new Neuron(w1);
            neuron[1] = new Neuron(w2);
            neuron[2] = new Neuron(w3);
            neuron[3] = new Neuron(w4);

        }

        public int Threshold(int threshold)
        {
            return (threshold >= 0) ? 1 : 0;
        }

        public void Activation(int[] pattern)
        {

        }
    } 
}
