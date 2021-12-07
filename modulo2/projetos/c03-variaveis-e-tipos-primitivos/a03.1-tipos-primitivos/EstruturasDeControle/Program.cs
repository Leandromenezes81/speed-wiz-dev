using System;

namespace EstruturasDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 100.0;
            double valorSaque = 110.0;
            
            // Código executado se a condição for verdadeira.
            if (saldo > valorSaque) 
            {
                Console.WriteLine("Saldo superior ao valor do saque.");
                //saldo = saldo - valorSaque;
                saldo -= valorSaque;
                Console.WriteLine(saldo);
            } else if (saldo == valorSaque)
            {
                Console.WriteLine("Valor do saque igual ao valor do saldo.");
                saldo -= valorSaque;
                Console.WriteLine(saldo);
            } else
            {
                Console.WriteLine("Saldo inferior ao valor do saque.");                
            }
            
           
        }
    }
}
