using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Csharp_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;
            float saldo;
            string nomeProduto;
            float valor;



            Console.WriteLine("----------Finalizar compra----------");
            Console.WriteLine();
            Console.WriteLine("----------Dados Usuario----------");

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("saldo: ");
            saldo = float.Parse(Console.ReadLine());

            Console.WriteLine("----------Dados Produto----------");

            Console.Write("Produto: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Valor: ");
            valor = float.Parse(Console.ReadLine());



            if(saldo < valor) {
                Console.WriteLine("Saldo insuficiente");
                saldo = valor - saldo;
                Console.WriteLine("Faltam R$" + saldo + " para efetuar a compra");
            } else{
                saldo = saldo - valor;
                Console.WriteLine("Compra efetuada");
                Console.WriteLine("Seu saldo agora é de R$" + saldo);
            }

            Console.ReadLine();

        }
    }
}
