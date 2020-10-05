using System;
using System.Threading;

namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

        Relatorio relatorio = new Relatorio(); 

        Anual anual = new Anual();

        Mensal mensal = new Mensal();

        bool sair = false;
         do
            {
                Console.WriteLine("Selecione o relatório que deseja emitir:");
                Console.WriteLine(" 1 - Mensal ");
                Console.WriteLine(" 2 - Anual ");
                Console.WriteLine("---------------------------");
                Console.Write("Digite a opção desejada: ");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        Console.WriteLine("Digite a data que deseja emitir:");
                        mensal.data = DateTime.Parse( Console.ReadLine());
                        Console.WriteLine("Data " +mensal.data);
                        anual.MostrarRelatorio();
                        Thread.Sleep(6000);
                        break;

                    case 2:
                        Console.WriteLine("Digite a data que deseja emitir:");
                        anual.data = DateTime.Parse( Console.ReadLine());
                        Console.WriteLine("Data " +anual.data);
                        anual.MostrarRelatorio();
                        Thread.Sleep(6000);
                        break;

                   
                    default:
                        System.Console.WriteLine("Código inválido, voltando para o menu..");
                        Thread.Sleep(3000);
                        break;

                }
            } while (!sair); 
         }
    }
}
