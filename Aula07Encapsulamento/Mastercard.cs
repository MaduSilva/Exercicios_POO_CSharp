using System;

namespace Aula07Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas { get; set;}

        public void ComprarComDescontoMastercard (float desconto){
            //interpolação usando chaves para relevar resultados
            //ctrl + . comando para ativar o using system
            //encapsulamento assinatura protected
            cvv = "579";

            Console.WriteLine($"Compra realizada em {parcelas} parcelas e R$ {desconto} de desconto");
        }

    }
}