namespace Aula06Heranca
{
    public class CNPJ : Pessoa //CNPJ herda da superclasse pessoa 
    {
        public string cnpj;

        public bool validarCNPJ(){
             // variavel bool que valida o cpf, se for um campo vazio (null) é false ,,
            if(cnpj != null){
                return true;
            }

            return false;

        }



    }
}