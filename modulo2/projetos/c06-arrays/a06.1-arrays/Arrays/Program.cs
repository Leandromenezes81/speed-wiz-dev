using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração explícita do Array
            double[] array = new double[8] {0.8, 1, 4.5, 9.0, 5, 6, 2, 2.3 };

            // Declaração implícita do Array
            double[] array2 = { 2.6, 5.7, 8, 9, 3.5, 6 };

            // Acessando os índices. Arrays iniciam na posição '0'.
            
            //Console.WriteLine(array[0]);

            /*
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            */

            foreach (var meuItem in array2)
            {
                Console.WriteLine(meuItem);
            }
        }
    }
}
