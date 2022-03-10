using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());
            
            while(numero-- > 0)
            {
              int valor = Convert.ToInt32(Console.ReadLine());
              int value = (int)Math.Sqrt(valor);
              int resp = valor - value;
              
              Console.WriteLine(resp);
            }
        }
    }
}
