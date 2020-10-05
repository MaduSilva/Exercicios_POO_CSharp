using System;

namespace Aula24ObjectsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
                //cria carrinho
            Carrinho cart = new Carrinho();
            
                //cria 4 produtos
            Produto p1 = new Produto(1, "GTA 5", 200.0f);
            Produto p2 = new Produto(2, "The Last of US", 150.0f);
            Produto p3 = new Produto(3, "Undertale", 40.0f);
            Produto p4 = new Produto(4, "God of War", 250.0f);  

                //adiciona 4 produtos no carrinho
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            
                //deleta o produto 4
            cart.Deletar(p4);

                //altera o produto 2
            Produto prodAlterado = new Produto(1, "CyberPunk 2077", 199.99f);
            cart.Alterar(2, prodAlterado);
            
                //após alteração lê o carrinho e mostra o valor total
            cart.Ler();
            cart.mostrarTotal();
        }
    }
}
