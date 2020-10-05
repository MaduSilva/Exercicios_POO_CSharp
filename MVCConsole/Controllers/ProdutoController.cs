using MVCConsole.Models;
using MVCConsole.Views;
using System.Collections.Generic;

namespace MVCConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto ();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            produtoView.MostrarNoConsole (produtoModel.Ler());
        }

        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarNoConsole(lista);
        }
    }
}