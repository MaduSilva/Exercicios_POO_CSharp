using System;

namespace ExercicioIngressos
{ 
    public class IngressoVip : Ingresso
    {
        public float valorAdicional = 10.0f;

        public void AdicionarValor(){

            float newValor = IngressoPreco + valorAdicional;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("O valor do ingresso VIP é : {0:c}",newValor);
            Console.ResetColor();
        }

    }
} 