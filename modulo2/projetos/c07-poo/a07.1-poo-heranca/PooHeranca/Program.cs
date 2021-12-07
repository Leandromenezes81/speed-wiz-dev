using System;

namespace PooHeranca
{
    // Nome da classe inicia com letra maiúscula.
    public class Veiculo
    {
        // Encapsulando o acesso aos atributos
        private string placa;
        private string chassi;

        // Criando método para acessar as informações encapsuladas anteriormente.
        public void ImprimirInformacoes()
        {
            chassi = "5987348jknfyhndmh";
            placa = "GTRE-8765";

            Console.WriteLine($"A placa é: {placa}");

            Console.WriteLine($"O chassi é: {chassi}");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um novo objeto 'Veiculo'.
            Veiculo meuVeiculo = new Veiculo();

            //meuVeiculo.chassi = "5987348jknfyhndmh";
            //meuVeiculo.placa = "GTRE-8765";

            //Console.WriteLine($"A placa é: {meuVeiculo.placa}");

            //Console.WriteLine($"O chassi é: {meuVeiculo.chassi}");

            meuVeiculo.ImprimirInformacoes();
        }
    }
}
