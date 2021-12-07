using System;

namespace EstruturaDeControleIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 100.0;
            double valorDoSaque = 100.0;

            if (saldo > valorDoSaque)
            {
                Console.WriteLine("Saldo maior que o valor do saque.");
                saldo -= valorDoSaque;
                Console.WriteLine($"Novo saldo: {saldo}");
            }
            else if (saldo == valorDoSaque)
            {
                Console.WriteLine("Saldo igual ao valor do saque.");
                saldo -= valorDoSaque;
                Console.WriteLine($"Novo saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Saldo inferior ao valor do saque.");
            }
            
        }
    }
}
