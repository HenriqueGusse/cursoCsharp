using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("--Finalizar Venda--");
            
            Console.Write("Codigo: ");
            int cod = int.Parse(Console.ReadLine());

            //Console.Write("Valor: ");
            //double valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());

            double valor = 0;

            if (cod == 6969){
                valor = 29.90;
            } else if (cod == 0066){
                valor = 95.49;
            }

            Console.WriteLine("Valor final: " + valor * quant + " reais");
            Console.ReadLine();
        }
    }
}
