using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci Fibo = new Fibonacci();
            Fibo.GerarSequenciaFibonacci(0,1,15);
            Console.WriteLine(Fibo.GerarFatorial(5));

        }
    }
}
