using System;

namespace TiposPrimitivosDois
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modificadores de acesso
            // public int altura = 30;
            // public permite que  código seja acessado por qualquer classe dentro do assembly.
            // private, protected e internal são outros tipos de modificadores de acesso.

            // A o início da nomeação de variáves se dar por letras e '_'
            int _codUsuario = 8;
            // As contantes são variáveis criadas em tempo de compilação e não podem ser alteradas.
            const double medida = 28.5;
            /* A tentativa de alteração após a criação da constante retornará erro.
               Ex: medidas = 30.6 - Não compilará. */

            Console.WriteLine(_codUsuario);
        }
    }
}
