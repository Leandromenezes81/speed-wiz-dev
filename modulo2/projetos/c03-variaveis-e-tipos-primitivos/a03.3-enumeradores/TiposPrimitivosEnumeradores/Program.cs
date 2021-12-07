using System;

namespace TiposPrimitivosEnumeradores
{
    /*
    enum Nivel
    {
        Baixo = 1,
        Medio = 2,
        Alto = 3
    }

    Nesse exemplo, a sáida do console será o próprio elemento
    do 'enum'.
    */
    class Program
    {
        enum Nivel
        {
            Baixo = 1,
            Medio = 2,
            Alto = 3
        }
        /* O enum pode ser declarado dentro da classe. Dessa forma, receberá
           implicitamente, o acesso private. Nesse exemplo, a saída do console
           será o valor atribuído aos elementos do 'enum'.
        */
        static void Main(string[] args)
        {
            //Nivel meuNivelAtual = Nivel.Medio;
            int meuNivelAtualInteiro = (int)Nivel.Alto;

            Console.WriteLine(meuNivelAtualInteiro);
        }
    }
}
