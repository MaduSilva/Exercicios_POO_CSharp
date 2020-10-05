
using System;

namespace ExercicioIngressos
{
    public class Ingresso
    {
        public float IngressoPreco {get; set;}

        public void ImprimirValor(){
            Console.WriteLine("O valor do ingresso normal é : R$ " + IngressoPreco);
        }

    }
}
