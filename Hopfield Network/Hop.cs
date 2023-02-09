using System;


namespace Hopfield_Network
{
    public class Hop
    {
        public static int Multiply(int[] matrixA, int[] matrixB)
        {
            int result = 0;

            for (int i = 0; i < matrixA.Length; i++)
            {
                for (int j = 0; j < matrixB.Length; j++)
                {
                    int sum = 0;
                    sum += matrixA[i] * matrixB[j];
                    result = sum;
                }
            }
            return result;
        }
    }
}
