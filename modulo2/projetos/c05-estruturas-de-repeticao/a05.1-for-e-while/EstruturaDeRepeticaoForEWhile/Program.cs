using System;

namespace EstruturaDeRepeticaoForEWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"O número é par: {i}");
                }
                else
                {
                    Console.WriteLine($"O número é ímpar: {i}");
                }
            }
            */

            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine($"O valor atual do contador é: {contador}");
                contador++;
            }
            
        }
    }
}
