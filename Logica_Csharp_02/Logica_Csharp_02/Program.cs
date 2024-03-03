using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Programa de Pagamentos-----");
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Escreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.ReadLine();
        }
    }
}
