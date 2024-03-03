using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double raio;
            double pi = 3.14159;

            Console.WriteLine("-----Calculando area-----");

            Console.Write("Valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(pi * raio * raio, 4));


            Console.ReadLine();
        }
    }
}
