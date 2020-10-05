namespace CalculadoraCSharp
{
    public class calculadoracientifica : calculadora
    {
        
        private string [] valores {get; set;}

        private float soma {get; set;}
        public void CalcularMedia(string txtConsole){

            resultado = 0;

            valores = txtConsole.Split(";");

            for (int i = 0; i < valores.Length; i++)
            {
                soma += float.Parse(valores[i]);
            }

            resultado = soma / valores.Length;
        }

        public void ControlarMetodos(string entradaUsuario){
            string [] dados = entradaUsuario.Split (" ");

            num1 = float.Parse(dados [0]);
            operador = dados[1];
            num2 = float.Parse(dados [2]);
         
         switch (operador){

             case "+":
             somar();
             break;

             case "-":
             subtrair();
             break;

             case "x":
             multiplicar();
             break;

             case "/":
             dividir();
             break;

             default:
             somar();
             break;

            }
        }
    }
}