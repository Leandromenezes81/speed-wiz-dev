using System;

namespace EstruturaDeControleSwitch
{
    class Program
    {
        enum Nivel
        {
            Baixo = 1,
            Medio = 2,
            Alto = 3
        }
        static void Main(string[] args)
        {
            //int valorAtual = 7;
            Nivel meuNivel = Nivel.Medio;
            switch (meuNivel)
            {
                case Nivel.Baixo:
                    Console.WriteLine("Nível Baixo.");
                    break;
                case Nivel.Medio:
                    Console.WriteLine("Nível Médio.");
                    break;
                case Nivel.Alto:
                    Console.WriteLine("Nìvel ALt0o");
                    break;
                default:
                    break;

                    /*
                    case 5:
                        Console.WriteLine("O valor atual corresponde a 5");
                        break;
                    case 10:
                        Console.WriteLine("O valor atual corresponde a 10");
                        break;
                    case 15:
                        Console.WriteLine("O valor atual corresponde a 15");
                        break;
                    default:
                        Console.WriteLine("O valor não possui correspondência para o caso.");
                        break;
                    */
            }
        }
    }
}
