using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finalizar Compra");

            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Saldo: ");
            int Saldo = int.Parse(Console.ReadLine());

            Console.Write("Nome do Produto: ");
            string NomeProduto = Console.ReadLine();

            Console.Write("Valor: ");
            int Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + Nome + ", Seu saldo é: " + Saldo + ", O produto é: " + NomeProduto + ", Que custa: " + Valor);
            Console.ReadLine();
        }
    }
}
