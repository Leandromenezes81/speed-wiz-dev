using System;

namespace PooMetodos
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

        #region Metodos

        // Método para imprimir as informações. O retorno desse método é uma string.
        // O parâmetro 'nomeVeiculo' está sendo passado no '()' como informação adicional.
        // A atribuição 'null' em 'nomeVeiculo' está sendo utilizada para validação.
        // Dessa forma, a variável inicia como 'null'.
        public string ImprimirInformacoes(string nomeVeiculo = null)
        {
            if (string.IsNullOrEmpty(nomeVeiculo))
            {
                return $"CHASSI: {Chassi} - PLACA: {Placa}";
            }
            else
            {
                return $"Nome veículo: {nomeVeiculo} - CHASSI: {Chassi} - PLACA: {Placa}";
            }            
            
        }
        #endregion
    }
    class Program
    {

        //Aula 7.3.1 - Métodos
        //static void MetodoExemplo(out int valor)
        // O método 'Multiplicar' corre o array 'parâmetros', multiplicando cada parâmetro passado
        // na saída do mesmo em 'Main'.
        static int Multiplicar(params int[] parametros)
        {
            /*
             Aula 7.3.2 - A palavra chave 'ref' passar a variável 'valor' como referência para o
             métod main. Com o operador '+=', a variável valor de 'MetodoExemplo' é incrementada a
             'valor' em 'Main'.
             
             Aula 7.3.3 - Outro tipo de implemnetação é usar o modificar acesso 'out'.
             Aula 7.3.3 - Modificador de acesso 'params'.
            */
            
            int valor = 1;
            //Console.WriteLine($"Valor em MetodoExemplo: {valor}");

            foreach (var parametro in parametros)
            {
                //valor = valor * parametro;
                valor *= parametro;
            }
            return valor;
        }
        static void Main(string[] args)
        {
            //int valor = 5;
            // Nessa implementação, o valor inserido em 'MetedoExemplo' não interfere no método Main.
            // É presico usar o modificador 'ref' na passagem de parâmetro.
            // Aula 7.3.3 - Usando modificador de acesso 'out'.
            //MetodoExemplo(out valor);
            //Console.WriteLine($"Valor em Main: {valor} ");

            /*
            Veiculo meuVeiculo = new Veiculo();

            meuVeiculo.Chassi = "9JHFJFHGUJD46746NJ";
            meuVeiculo.Placa = "QUJ-2679";

            // O parâmetro "Ferrari", de'nomeVeiculo' está sendo passado no '()' como informação adicional
            Console.WriteLine(meuVeiculo.ImprimirInformacoes("Lamborgini"));
            */

            // Aula 7.3.3 (Parte 2) - Parâmetros
            Console.WriteLine(Multiplicar(10, 20, 30, 40));
            // Essas duas saídas executam o0 método 'Multiplicar'.
            Console.WriteLine(Multiplicar(10, 20, 30, 40, 50, 60));
        }
    }
}
