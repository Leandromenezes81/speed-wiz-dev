using System;

namespace Abstracao
{
    public abstract class Veiculo
    {

        #region Propriedades

        // Implementando uma propriedade abstrata.
        public abstract bool MotorLigado { get; set; }
        public bool MotorPartidaAcionado { get; set; }
        public bool InjetadoCombustivel { get; set; }

        #endregion

        #region Construtor

        public Veiculo()
        {
            Console.WriteLine("Eu sou um veículo.");
        }

        #endregion

        #region Metodos

        public abstract void Ligar();

        public abstract void Acelerar();

        public abstract void Frear();

        #endregion

        // Uma classe abstrata não pode ser instanciada. Para
        // utilizar seus seus métodos utilizamos a herança, criando
        // outra classe e reutilizando seus átributos e métodos.

    }

    // A palavra chave 'override' sobrescreve a declaração dos métodos
    // da classe abstrata.
    public class Carro : Veiculo
    {
        #region Construtor

        public Carro()
        {
            Console.WriteLine("Eu sou um carro.");
        }


        // Implementação de propriedade abstrata.
        public override bool MotorLigado { get; set; }

        #endregion

        public override void Acelerar()
        {
            throw new NotImplementedException();
        }

        public override void Frear()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            // Redefinição do método ligar.

            InjetadoCombustivel = true;

            MotorLigado = true;

            Console.WriteLine("O carro está ligado.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Carro carro = new Carro();

            carro.Ligar();

            //Console.WriteLine("Hello World!");
        }
    }
}
