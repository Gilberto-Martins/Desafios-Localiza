using System;
using System.Linq;
using System.Collections.Generic;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            var joias = new List<string>();

            while (true)
            {
                string recJoia = Console.ReadLine();

                if(!string.IsNullOrWhiteSpace(recJoia))
                {
                    joias.Add(recJoia);
                }
                else
                {
                    break;
                }
            }
            var totalJoias = joias.Distinct().ToList();

            Console.WriteLine(totalJoias.Count);
        }
    }
}
