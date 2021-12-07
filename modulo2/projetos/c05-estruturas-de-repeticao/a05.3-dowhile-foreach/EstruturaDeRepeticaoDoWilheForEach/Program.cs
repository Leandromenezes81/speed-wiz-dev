using System;

namespace EstruturaDeRepeticaoDoWilheForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            /*
            do
            {
                Console.WriteLine($"O valor do contador é {contador}.");
                contador++;
            } while (contador <= 10);
            */

            string[] linguagens = { "C#", "Java", "Typescript", "Python" };

            char[] letras = { 'A', 'B', 'C', 'D' };
                    
            //Acessando coleções com 'for'.
            for (int i = 0; i < linguagens.Length; i++)
            {
                Console.WriteLine(linguagens[i]);
            }

            //foreach (var item in linguagens)
            /*
            foreach (var letra in letras)
            {
                Console.WriteLine(letra);
            }
            */
        }
    }
}
