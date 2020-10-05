namespace Aula22Static
{
    public static class Conversor
    {
        public static float DolarAgora = 5.25f;
        public static float EuroAgora = 5.92f;

        public static float ConverterRealDolar(float valor){
            return valor * DolarAgora;
        }

        public static float ConverterDolarReal(float valor){
            return valor / DolarAgora;
        }

        public static float ConverterEuroReal(float valor){
            return valor * EuroAgora;
        }

        public static float ConverterRealEuro(float valor){
            return valor / EuroAgora;
        }

    }
}