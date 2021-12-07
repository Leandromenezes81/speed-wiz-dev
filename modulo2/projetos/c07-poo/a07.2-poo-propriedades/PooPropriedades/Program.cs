using System;

namespace PooPropriedades
{

    public class Veiculo
    {
        // Criação dos atributos da classe.
        #region Campos

        // Modificador de acesso private sendo atribuído implicitamente para os campos.
        string placa;
        string chassi;

        #endregion

        // As propriedades serão utilizadas para acessar os campos. Modificador de acesso 'public'.
        #region Propriedades
        
        // Por convenção, as propriedades iniciam por letra maiúscula.
        public string Placa
        {
            // Leitura
            get
            {
                return placa;
            }

            // Escrita
            set
            {
                // 'value' - Palavra chave utilizada para atribuir valor ao atributo.
                placa = value;
            }
        }

        public string Chassi
        {
            // Forma diferente de escrever o método (SintaxSuggar)
            get => chassi;
            set => chassi = value;
        }

        #endregion


    }
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo meuVeiculo = new Veiculo();

            meuVeiculo.Chassi = "9JHFJFHGUJD46746NJ";
            meuVeiculo.Placa = "QUJ-2679";
            
            Console.WriteLine($"CHASSI: {meuVeiculo.Chassi} - PLACA: {meuVeiculo.Placa}");
        }
    }
}
