using System;

namespace ExercicioTryCatch
{
    public class Permissao
    {
            //anotações
            //public pode herda-lo e private não
            //usa-se o private para n chamar coisas em outro lugar e só pode ser acessado dentro da class
            //get-set: aquilo que eu to declarando antes posso inserir e retornar 
         private bool Permitir { get; set; }
            //void n tem necessidade de retornar
        public void Autorizar(){

            //vai tentar fazer algo, se n der certo vai tentar pegar a excessão, é praticamente um if e else que executa metodo
            try{

                Console.WriteLine("Deseja permitir acesso? Digite True or False");
                Permitir = Boolean.Parse( Console.ReadLine() );

            }catch(Exception){

                Console.WriteLine("Erro na aplicação: dados inválidos");

            }
        }
    }
}