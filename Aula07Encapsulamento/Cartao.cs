using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        //prop spawnna variavel com get set

        public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        private string token = "hd87h1783h1278js89127387912hj13sdhu21j8";

        protected string cvv { get; set; }

        //metodos
        //Void é um metodo sem retorno, porém n abusar do uso
        public void AprovarCompra(){
            Console.WriteLine("Compra aprovada com sucesso");
        }

        private bool ValidarToken(){
            if (token != null){

            return true;
        }  
            return false;
        }
        
        protected bool ValidarCompra(){
            return true;
        }

    }
}