using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abdiagsd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            double c;
            double delta;
            double x1;
            double x2;
            double raiz;

            Console.Write("Valor de a ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Valor de b ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Valor de c ");
            c = float.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            raiz = Math.Sqrt(delta);

            if (raiz == 0 || a == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {

                x1 = ((-b) + raiz) / (2 * a);
                x2 = ((-b) - raiz) / (2 * a);

                Console.WriteLine(Math.Round(x1, 5));
                Console.WriteLine(Math.Round(x2, 5));
            } 
            Console.ReadLine(); 

        }
    }
}
