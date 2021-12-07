using System;

namespace Polimorfismo
{
    public abstract class Pessoa
    {

        #region Metodos

        public abstract decimal CalcularVendas();

        #endregion

    }

    public class Vendedor : Pessoa
    {
        public override decimal CalcularVendas()
        {
            decimal valorUnitario = 50;

            decimal produtosVendidos = 1500;

            return valorUnitario * produtosVendidos;
        }
    }


    public class Diretor : Pessoa
    {
        public override decimal CalcularVendas()
        {
            decimal valorUnitario = 70;

            decimal produtosVendidos = 3600;

            decimal taxaAdicional = 100;

            return taxaAdicional + (valorUnitario * produtosVendidos);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
             Na implementação abaixo, foram criados dois objetos Pessoa, assumindo formas diferentes
             como a de 'Vendedor' e 'Diretor'. Dessa forma, esses dois objetos, mesmo pertecendo ao
             tipo Pessoa, podem assumir comportamentos distintos e os métodos da classe 'Pai', podem
             ser sobrescritos pelos métodos das classes 'Filhas'.
            */

            Pessoa vendedor = new Vendedor();

            Console.WriteLine($"O vendedor vendeu :: {vendedor.CalcularVendas()}");

            Pessoa diretor = new Diretor();

            Console.WriteLine($"O diretor vendeu :: {diretor.CalcularVendas()}");
        }
    }
}
