using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao card = new Cartao();
            card.AprovarCompra();

            Mastercard master = new Mastercard();
            master.parcelas = 12;
            master.ComprarComDescontoMastercard(50f); // f de float

        }
    }
}
