using System;
using System.Collections.Generic;

namespace Aula24ObjectsArguments
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }

        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }

        public void Ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }
        }

        public void Alterar(int _cod, Produto _prodAlterado)
        {
            carrinho.Find(z => z.Codigo == _cod).Nome = _prodAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _prodAlterado.Preco;
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