using System;

namespace Interface
{

    public interface IAnimal
    { 
    
    string Nome { get; set; }
    string QuemSouEu();
    
    }

    public class Cachorro : IAnimal
    {
        #region Propriedades

        public string Nome { get; set; }

        #endregion

        #region Metodos

        public string QuemSouEu()
        {
            return $"Olá, eu sou um cachorro e meu nome é: {Nome}";
        }

        #endregion
    }

    public class Gato : IAnimal
    {
        #region Propriedades

        public string Nome { get; set; }

        #endregion

        #region Metodos

        public string QuemSouEu()
        {
            return $"Olá, eu sou um gato e meu nome é: {Nome}";
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal cachorro = new Cachorro
            {
                Nome = "Charlie"
            };            
            
            Console.WriteLine(cachorro.QuemSouEu());


            IAnimal gato = new Gato
            {
                Nome = "Claws"
            };

            Console.WriteLine(gato.QuemSouEu());
        }
    }
}
