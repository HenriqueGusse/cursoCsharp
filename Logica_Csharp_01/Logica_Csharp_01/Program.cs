using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_01
{
    class Program
    {
        static void Main(string[] args)
        {
            char pLetra;
            string nome;
            float idade;
            bool comecaComH;

            pLetra = 'F';
            nome = "Henrique";
            idade = 15;

            if (pLetra == 'H')
            {
                comecaComH = true;
            } else{
                comecaComH = false;
            }


            Console.WriteLine(comecaComH);
            Console.ReadLine();

        }
    }
}
