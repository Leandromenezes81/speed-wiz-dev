using System;

namespace MetodosVirtuais
{
    public class Heroi
    {
        public virtual void MostrarMinhaHabilidade()
        {
            Console.WriteLine("Eu tenho superforça!");        
        }
    }

    public class HomemAranha : Heroi
    {
        public override void MostrarMinhaHabilidade()
        {
            base.MostrarMinhaHabilidade();

            Console.WriteLine("Eu tenho agilidade!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            HomemAranha spider = new HomemAranha();

            spider.MostrarMinhaHabilidade();
        }
    }
}
