using System;

namespace Introdução_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi Lux = new Heroi();
            Lux.nome = "Luxanna Stemmaaguarda";
            Lux.equipamento = "Cajado";

            Console.WriteLine(Lux.nome);
            Console.WriteLine(Lux.Defender());
            Console.WriteLine(Lux.Atacar(100.5f, 50f));
        }
    }
}
