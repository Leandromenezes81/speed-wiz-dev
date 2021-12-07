using System;

namespace TiposPrimitivosStructs
{
    class Program
    {
        struct Medidas
        {
            /* 
             * O mofificador de acesso public permite que os atributos
             * sejam acessados de fora da estrutura 'struct'.
             */
            public int altura;
            public int largura;
        }
        static void Main(string[] args)
        {
            // Criação de uma struct (similar a cração de um objeto).
            
            Medidas medidas = new Medidas();

            medidas.altura = 135;
            medidas.largura = 28;

            Console.WriteLine(medidas.altura + " " + medidas.largura);
        }
    }
}
