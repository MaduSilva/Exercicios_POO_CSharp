using System;

namespace ConsoleUber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro maria = new Passageiro();

            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            maria.Login(login, senha);

            if(maria.TokenLogin != "" && maria.TokenLogin !=null){
                System.Console.WriteLine("Login Autorizado!");
                System.Console.WriteLine(maria.TokenLogin);
            } else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }
            
        }
    }
}
