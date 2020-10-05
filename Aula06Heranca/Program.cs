using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //instanciar a classe filha
            CPF cadastropessoafisica = new CPF();
            cadastropessoafisica.nome = " Maria";
            //digitar cw spawnna um console write line
            System.Console.WriteLine(cadastropessoafisica.Welcome());

            cadastropessoafisica.cpf = "000.000.000-00";
            System.Console.WriteLine( cadastropessoafisica.validarCPF());

        }
    }
}
