using System;

namespace CalculadoraCSharp
{
class Program 
    {
  static void Main (string[] args) 
    {

     calculadoracientifica calc = new calculadoracientifica();


    Console.WriteLine ("Calculadora");
    Console.WriteLine ("----------------------------------");

     Console.WriteLine ("Digite uma operação (exemplo 10 x 5 ):");
     calc.ControlarMetodos(Console.ReadLine());
     Console.WriteLine("Resultado: "+calc.resultado);

     Console.WriteLine("Calcule a média separando os números com ponto e vírgula (exemplo: 2;5;10):" );
     calc.CalcularMedia(Console.ReadLine());
     Console.WriteLine("A média é:"+calc.resultado);

        }
    }
}