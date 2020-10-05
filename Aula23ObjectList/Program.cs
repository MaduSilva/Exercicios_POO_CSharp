using System;
using System.Collections.Generic;

namespace Aula23ObjectList
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando a lista
        List<Produto> produtos = new List<Produto>();

            //Adicionando produtos através de instancias com construtores
        
        produtos.Add(new Produto(1, "Iphone 8", 3000.0f));
        produtos.Add(new Produto(2, "Motorola G8", 1500.0f));
        produtos.Add(new Produto(3, "Galaxy S10", 2800.75f));
        produtos.Add(new Produto(4, "Alexa", 249.0f));
        produtos.Add(new Produto(5, "Ipad 7", 3149.99f));

            //Adicionando através de instancias básicas e suas atribuições
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Produto alexa = new Produto();
        alexa.Codigo = 10;
        alexa.Nome = "Amazon Alexa";
        alexa.Preco = 249.0f;

        produtos.Add(alexa);

            //Mostrando produtos com foreach
        foreach(Produto p in produtos){
            Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
        }

            //Remover itens 
        produtos.RemoveAt(3);

        produtos.RemoveAll(x => x.Nome == "Iphone 8");

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nLista alterada: ");

        foreach(Produto p in produtos){
            Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
        }


        }
    }
}
