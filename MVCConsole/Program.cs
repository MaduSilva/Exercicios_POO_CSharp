using System;
using MVCConsole.Controllers;

namespace MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produto = new ProdutoController();
           produto.Listar();
           produto.Filtrar("1,99");
        }
    }
}
