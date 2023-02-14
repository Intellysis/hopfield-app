using System.Linq;
using System.Collections.Generic;

namespace Hopfield_Network
{
    internal class Network
    {
        public Neuron[] neuron = new Neuron[9];
        public int[] output = new int[9];

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
            return (threshold >= 0) ? 1 : -1;
        }

        public void Activation(int[] pattern)
        {
            bool isStable = false;
            output = pattern;

            while (!isStable)
            {
                List<int[]> patternList = new List<int[]>();

                for (int i = 0; i < 9; i++)
                {
                    neuron[i].activation = neuron[i].Act(9, output);
                    output[i] = Threshold(neuron[i].activation);

                    patternList.Add((int[])output.Clone());
                }

                isStable = StabilityChecker(patternList);
            }
        }

        /// <summary>
        /// Checks if the generated list of outputs in each weight rows are all equal 
        /// wherein this shows stability
        /// </summary>
        /// <param name="patternList">List that stores all generated output in each weight row</param>
        /// <returns>True if stable, otherwise false</returns>
        public bool StabilityChecker(List<int[]> patternList)
        {
            bool isStable = true;
            for (int i = 1; i < patternList.Count; i++)
            {
                if (!patternList[i].SequenceEqual(patternList[0]))
                {
                    isStable = false;
                    break;
                }
            }

            return isStable;
        }
    }
}
