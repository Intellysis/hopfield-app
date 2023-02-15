namespace Hopfield_Network
{
    internal class Neuron
    {
        public int[] weightv = new int[9];
        public int activation;

        public Neuron(int[] neuron)
        {
            for(int i = 0; i < 9; i++)
            {
                weightv[i] = neuron[i];
            }
        }

        public int Act( int m, int[] x )
        {
            int a = 0;
            for( int i = 0; i < m; i++ )
            {
                a += x[i] * weightv[i];
            }
            return a;
        }
    }
}
