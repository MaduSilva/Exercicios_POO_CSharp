using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia sem argumentos
           Produto sapato = new Produto();
           sapato.Nome = "Vizzano";

            //instancia com 1 argumento
           Produto chinelo = new Produto(45);
           System.Console.WriteLine(chinelo.Codigo);

           //instancia com todos os atributos 

           Produto camisa = new Produto(768, "Supreme", "Malha", 105);
           System.Console.WriteLine("O código da camisa é "+camisa.Codigo);
           System.Console.WriteLine("A marca da camisa é " +camisa.Nome);
           System.Console.WriteLine("Tecido: " +camisa.Descricao);
           System.Console.WriteLine("Atualmente existem "+camisa.Estoque+" camisas no estoque");
        }
    }
}
