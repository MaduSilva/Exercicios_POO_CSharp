namespace CalculadoraCSharp
{
    public class calculadora
    {
        public float num1  { get; set; }

        public float num2 { get; set; }

        public float resultado { get; set; }

        public string operador { get; set; }

        public void somar(){
            resultado = 0;
            resultado = num1 + num2;
        }

        public void subtrair(){
            resultado = 0;
            resultado = num1 - num2;
        }

        public void multiplicar(){
            resultado = 0;
            resultado = num1 * num2;
        }

        public void dividir(){
            resultado = 0;
            resultado = num1 / num2;
        }

        }
    }
