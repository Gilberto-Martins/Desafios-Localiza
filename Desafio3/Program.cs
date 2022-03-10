using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;

            Console.Write("Digite o valor do Raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            raio = Math.Pow(raio, 3.0);

            volume = (4/3.0) * pi * raio;

            Console.WriteLine($"Volume : {volume.ToString("f3")}");
        }
    }
}
