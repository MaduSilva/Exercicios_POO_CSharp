using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente paulo = new Cliente("Paulo Brandão");
            paulo.EnderecoAtual = "Rua Abobrinha, 347";

            Restaurante skyAsia = new Restaurante("Burguer King", "Shopping Grand Plaza");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente  = paulo;
            pedido1.Restaurante = skyAsia;

           System.Console.WriteLine(pedido1.EntregarPedido()); 
            

        
        }
    }
}
