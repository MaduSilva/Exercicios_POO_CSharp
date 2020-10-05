namespace Introdução_POO
{
    public class Heroi
    {
        public string nome;
        public int idade;
        public string equipamento;

        public float Atacar(float mana , float stamina){
            return mana * stamina;

        }

        public string Defender (){
            return "O herói ativou sua habilidade ultimate";
        }
    }
}