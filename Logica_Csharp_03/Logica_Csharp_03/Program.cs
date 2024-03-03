using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string priNome, segNome;

            priNome = "Henrique";
            segNome = "Ivankio";


            string NomeCompleto = string.Concat(priNome, " ",segNome, " Gusse");

            Console.WriteLine(NomeCompleto);
            Console.ReadLine();

        }
    }
}
