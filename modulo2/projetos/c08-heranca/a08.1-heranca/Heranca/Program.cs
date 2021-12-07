using System;

namespace Heranca
{
    public class Conta
    {

        public string NomeDoCliente { get; set; }
        public string NumeroDaConta { get; set; }
        public decimal Saldo { get; set; }

    }

    // Atribuiição de Herança - ClasseFilha : ClassePai
    // Em C#, não é possível herança multipla.
    public class ContaEspecial : Conta
    {
        public decimal Limite { get; set; }
    }


    public class ContaPoupanca : Conta
    {
        public decimal Taxa { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Conta contaSimples = new Conta();

            ContaEspecial contaEspecial = new ContaEspecial();

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            
            Console.WriteLine("Hello World!");
        }
    }
}
