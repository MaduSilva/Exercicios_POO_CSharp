using System;

namespace Aula26Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "Ruffles", 7.76f);
            Produto p2 = new Produto(2, "Doritos", 12.90f);
            Produto p3 = new Produto(3, "Lays", 6.99f);
            Produto p4 = new Produto(4, "Fandagos", 13.90f);

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Cadastrar(p4);

            carrinho.Deletar(p3);

            Produto ProdutoAlterado = new Produto(4, "Pringles", 18.89f);
            carrinho.Alterar(4, ProdutoAlterado);

            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            carrinho.mostrarTotal();

            Console.ResetColor();
        }
    }
}
