namespace Aula06Heranca
{
    public class CPF : Pessoa //CPF herda da superclasse pessoa
    {
        public string cpf;

        public string rg;

        public bool validarCPF(){
            // variavel bool que valida o cpf, se for um campo vazio (null) é false
            if(cpf != null){ 
                return true;
            }

            return false;
        }

    }
}