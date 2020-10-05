using System;

namespace ExercicioIngressos
{
    class Program
    {
        static void Main(string[] args)
        {

            IngressoVip bilhete = new IngressoVip();
            bilhete.IngressoPreco = 13.90f;
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            System.Console.WriteLine("A diferença de valores é: R$" + bilhete.valorAdicional);

        }
    }
}