using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito nubank = new CartaoCredito();
            nubank.limite = 3000f;

            Console.WriteLine("Digite a quantidade de acréscimo que deseja no limite");
            float acrescimo = float.Parse( Console.ReadLine() );

            nubank.AumentarLimite(acrescimo);
            Console.WriteLine("O novo limite é de R$"+nubank.limite);
            
        Console.WriteLine("Digite a data do pagamento");
        nubank.data = DateTime.Parse( Console.ReadLine());
        Console.WriteLine("Data" +nubank.data);
        
        }
    
    }
}
