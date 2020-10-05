using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : Icarrinho
    {
        public float ValorTotal { get; set; }
        List <Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto _produtoalterado)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoalterado.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoalterado.Preco;
        }
        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }
        public void Listar()
        {
            foreach(Produto item in carrinho){
            System.Console.WriteLine($"R$ {item.Preco,2} - {item.Nome}");
            }
        }

        public void Deletar(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

         public void mostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Valor total da compra: R$ {ValorTotal}");
        Console.ResetColor();
        }
    }
}