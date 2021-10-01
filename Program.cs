using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore = new int[5] { 3, 6, -3, 5, 7};
            int min = vettore[0];
            for(int i = 1; i < vettore.Length; i++)
            {
                if (vettore[i] < min)
                    min = vettore[i];
            }
            Console.WriteLine(min);
            Console.ReadKey();






        }
    }
}
