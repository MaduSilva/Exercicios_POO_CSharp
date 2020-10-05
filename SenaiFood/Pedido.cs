using System;

namespace Ifood
{
    public class Pedido
    {

        //mais de um item
        public string[] Itens { get; set; }

        public Cliente Cliente { get; set; }

        public Restaurante Restaurante { get; set; }

        public string FormaDePGTO { get; set; }

        public bool PedidoPago { get; set; }

        public DateTime DataEntrega { get; set; }

          public string EntregarPedido(){
            
            DataEntrega = DateTime.Now;

            string retorno = "Pedido entregue! \n";
            retorno += Restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();
            retorno += DataEntrega;

            return retorno;
        }
    }
}