using System;

namespace Aula25Recursividade
{
    public class Fibonacci
    {
         public void GerarSequenciaFibonacci(int numero1, int numero2, int vezes)
    {
             if(vezes>0){
	        Console.WriteLine(numero1);
	        GerarSequenciaFibonacci(numero2, numero1 + numero2, vezes - 1);
    }
}

        public int GerarFatorial(int numero){

        if(numero == 1){
            	return 1;
        }else{
            	return numero * GerarFatorial(numero - 1);
}
}
}
}