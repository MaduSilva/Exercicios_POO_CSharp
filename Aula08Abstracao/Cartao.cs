namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "heuqwheuiwqsmaiw1823h1i9hdsanhehehehe(#&4861jjuaua1";

        public string titular { get; set;}

        public int numero { get; set; }

        public string cvv { get; set; }

        public string bandeira { get; set; }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
                return false;
        }
    }
}