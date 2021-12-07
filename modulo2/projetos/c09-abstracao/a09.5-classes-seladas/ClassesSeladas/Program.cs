using System;

namespace ClassesSeladas
{

    public partial class Cliente
    {

        #region Propriedades

        public int Identificador { get; set; }
        public string Endereco { get; set; }

        #endregion

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

    // O modificador de acesso 'sealed' impede que essa classe seja herdada.
    public sealed class ClienteEspecial : Cliente
    {
        #region Propriedades

        public decimal Bonus { get; set; }

        #endregion
    }

    // Erro retornado pelo IDE com a tentativa de herança de uma classe selada.
    public class NovoClienteEspecial : ClienteEspecial
    {
        #region Propriedades
        public string Limite { get; set; }
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

            novoCliente.AtualizaEndereco("Rua CDA");

            ClienteEspecial clienteEspecial = new ClienteEspecial();
        }
    }
}
