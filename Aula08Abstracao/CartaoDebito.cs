namespace Aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo { get; set; }

        public string PagarTitulo(){
            return "Título Pago";
        }
    }
}