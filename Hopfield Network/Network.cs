using System.IO;
using System;
using System.Runtime.InteropServices;

namespace Hopfield_Network
{
    internal class Network
    {
        Neuron[] neuron = new Neuron[4];
        int[] output = new int[4];

        public Network(int[] w1, int[] w2, int[] w3, int[] w4, int[] w5, int[] w6, int[] w7, int[] w8, int[] w9)
        {
            neuron[0] = new Neuron(w1);
            neuron[1] = new Neuron(w2);
            neuron[2] = new Neuron(w3);
            neuron[3] = new Neuron(w4);
            neuron[4] = new Neuron(w5);
            neuron[5] = new Neuron(w6);
            neuron[6] = new Neuron(w7);
            neuron[7] = new Neuron(w8);
            neuron[8] = new Neuron(w9);

        }

        public int Threshold(int threshold)
        {
            return (threshold >= 0) ? 1 : 0;
        }

        public void Activation(int[] pattern)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.WriteLine("neuron[" + i + "].weightv[" + j + "] is " + neuron[i].weightv[j]);
                }
                neuron[i].activation = neuron[i].Act(4, pattern);
                Console.WriteLine("activation is " + neuron[i].activation);
                output[i] = Threshold(neuron[i].activation);
                Console.WriteLine("output value is " + output[i] + "\n");
            }
        }
    } 
}
