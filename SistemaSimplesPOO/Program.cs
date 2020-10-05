using System;
using System.Threading;

namespace SistemaSimplesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
           celular motorola = new celular();
           motorola.modelo = "Motorola One Macro";
           motorola.cor = "Roxo";
           motorola.tamanho = "Tela de 6 polegadas";

           Console.WriteLine("O celular está ligado?");
           motorola.situacao = motorola.VerEstado(Console.ReadLine());
           
           bool sair = false;
             do
            {
                System.Console.WriteLine("Celular");
                System.Console.WriteLine(" ");
                System.Console.WriteLine(" 1 - Enviar Mensagem ");
                System.Console.WriteLine(" 2 - Efetuar Ligação ");
                System.Console.WriteLine(" 3 - Desligar ");
                System.Console.WriteLine("---------------------------");
                System.Console.Write("Digite a opção desejada: ");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do destinatário da mensagem");
                        Console.ReadLine();
                        Console.WriteLine("Digite a mensagem");
                        Console.ReadLine();
                        Console.WriteLine("Mensagem enviada");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Digite o número do contato");
                        Console.ReadLine();
                        Console.WriteLine("Ligando...");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Desligando....");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    default:
                        System.Console.WriteLine("Código inválido, voltando para o menu..");
                        Thread.Sleep(3000);
                        Console.Clear();
                        sair = true;
                        break;
                }

            } while (!sair); 
        }
    }
}
    




        
    

