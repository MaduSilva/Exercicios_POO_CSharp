using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("Hoje o dólar equivale em reais a");
            Console.WriteLine(Conversor.DolarAgora = 5.25f);

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Sua conversão DOLAR > REAL:");
            Console.WriteLine(Conversor.ConverterRealDolar(13));

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Sua conversão REAL > DOLAR");
            Console.WriteLine(Conversor.ConverterDolarReal(13));

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Hoje o euro equivale em reais a");
            Console.WriteLine(Conversor.EuroAgora = 5.92f);

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Sua conversão EURO > REAL:");
            Console.WriteLine(Conversor.ConverterEuroReal(13));

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Sua conversão Real > EURO:");
            Console.WriteLine(Conversor.ConverterRealEuro(13));
        
            Console.ResetColor();
        }
    }
}
