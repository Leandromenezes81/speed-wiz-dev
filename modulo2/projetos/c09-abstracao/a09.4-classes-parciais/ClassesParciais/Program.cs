using System;

namespace ClassesParciais
{

    public partial class Cliente
    {

        #region Propriedades

        public int Identificador { get; set; }
        public string Endereco { get; set; }

        #endregion

    }

    public partial class Cliente
    {

        #region Metodos

        public void AtualizaEndereco(string novoEndereco)
        {
            if (!string.IsNullOrEmpty(novoEndereco))
            {
                Endereco = novoEndereco;
            }
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente novoCliente = new Cliente
            {
                Identificador = 12345,
                Endereco = "Rua ABC"
            };
                
        
        

            Console.WriteLine($"Cliente identificador: {novoCliente.Identificador} - Endereço: {novoCliente.Endereco}");

            novoCliente.AtualizaEndereco("Rua CDA");

            Console.WriteLine($"Cliente identificador: {novoCliente.Identificador} - Novo endereço: {novoCliente.Endereco}");
        }
    }
}
