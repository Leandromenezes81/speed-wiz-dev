using System;

namespace TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoDoUsuario = 20;
            int idade = 20;
            double valorDosSaldo = 150.00;
            double latitude = -18.7465464;
            char genero = 'F';

            // Conversão implícita, sem a necessidade de código para converter 'int' em 'decimal'.
            decimal novoValor = 300;

            // Conversão explícita (Casting). 'M' - Notação para valores decimais.
            decimal valorDecimal = 45.75M;
            int novoValorInteiro = (int)valorDecimal;

            // Conversão com classes auxiliares.
            int identificador = Convert.ToInt32("123456778");
            
            Console.WriteLine(identificador);
        }
    }
}
