using System;

namespace PooSobrecarga
{
    public class Retangulo
    {
        #region Campos
        private int x;
        private int y;
        #endregion

        #region Propriedades
        public int X 
        { 
            get { return x; }        
        }
        public int Y => y;
        #endregion

        #region Construtor
        // Construtor sem parâmetros.

        public Retangulo ()
        {
            this.x = 0;
            this.y = 0;

            Console.WriteLine("Construtor sem parâmetros.");
        }

        // Construtor com parêmetros.
        public Retangulo(int x, int y) : // ':' - Utilizado para a refenciação do construtor sem parâmetros.
        // Referenciando o construtor sem parâmetros
        this()
        {
           this.x = x;
           this.y = y;
        }

        #endregion
    }

    class Program
    {
        // A Sobrecarga é utilizada quando se deseja manter uma implementação
        // com poucas alterações. Nesse caso, os métodos abaixo possuem o mesmo nome
        // com assinaturas diferentes, ou seja, os parâmetros no segundo
        // método possuem uma implementação a mais.
        static int Calcular (int largura, int altura)
        {
            return 0;
        }

        static int Calcular(int largura, int altura, int x, int y)
        {
            return 0;
        }

        static int Calcular (Retangulo ret)
        {
            return 0;
        }

        static void Main(string[] args)
        {
            // Utilizando a atribuição declareada no construtor com parâmetros.
            Retangulo meuRetangulo = new Retangulo(10, 20);

            // Utilizando a atribuição declareada no construtor sem parâmetros.
            //Retangulo meuRetangulo2 = new Retangulo();

            Console.WriteLine(meuRetangulo.X);


        }
    }
}
