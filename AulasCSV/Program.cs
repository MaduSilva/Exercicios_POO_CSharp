using System;
using System.Collections.Generic;

namespace Aula_27_28_29_30 {
    class Program {
        static void Main (string[] args) {
            Produto p1 = new Produto ();
            p1.Codigo = 3;
            p1.Nome = "Sonic Generations";
            p1.Preco = 1.99f;

            p1.Cadastrar (p1);
            p1.Remover ("Terraria");

            List<Produto> lista = new List<Produto> ();
            lista = p1.Ler ();

            foreach (Produto item in lista) {
                Console.WriteLine ($"R$ {item.Preco} - {item.Nome}");
            }

        }
    }
}