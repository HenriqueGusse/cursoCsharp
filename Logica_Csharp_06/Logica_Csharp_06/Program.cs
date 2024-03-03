using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int contador;

            //for (contador = 0; contador < 100; contador++) {
            //Console.WriteLine(contador);
            //}

            string[] nomes = new string[6] { "H", "E", "N", "R", "I", "Q" };
            //int contador;


            for (int contador = 0; contador < nomes.Length; contador++) {
                Console.WriteLine(nomes[contador]);
            }










            Console.ReadKey();
        }
    }
}
