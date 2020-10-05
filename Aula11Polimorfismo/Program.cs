using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoHero = new Calculo();

            //1ª opção, sem argumentos
            System.Console.WriteLine( infoHero.Calcular() );

            //2ª opção, com 1 argumento int 
            System.Console.WriteLine( infoHero.Calcular(100));

            //3ª opção, com 2 argumentos int 
            System.Console.WriteLine( infoHero.Calcular(100,90) );

            // 4º opção, com 2 argumentos string
            System.Console.WriteLine( infoHero.Calcular("Luxanna ", "Stemmaguarda") );
        }
    }
}
