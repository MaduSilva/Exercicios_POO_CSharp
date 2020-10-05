using System.Threading;

namespace SistemaSimplesPOO
{
    public class celular
    {
        public string modelo;
        public string cor;
        public string tamanho;
        public bool situacao;
        public string estado;

        public string contato;
        /// <summary>
        /// Verifica se o celular está ligado
        /// </summary>
        /// <returns>Resultado do estado atual do celular</returns>
        /// 
            public bool VerEstado(string estado){

            if(estado == "não"){
             System.Console.Write("Ligando celular....");
             Thread.Sleep(3000);
             System.Console.Clear();
            }else{
                
            }
            return situacao;
        }
    }
}