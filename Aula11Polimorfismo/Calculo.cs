namespace Aula11
{
    public class Calculo
    {
        public string Calcular(){
            return "Não houve nenhum calculo a ser aplicado";
        }

        public string Calcular(int vida){
            return "A vida do herói é "+vida;
        }

        //o que determina a sobrecarga é o tipo dos argumentos, parametros
        public string Calcular(int vida, int escudo){
            return "A vida do herói com escudo é " + (vida+escudo);
        }

        public string Calcular(string nome, string sobrenome){
            return "O herói se chama " + (nome + sobrenome);
        }
    }
}