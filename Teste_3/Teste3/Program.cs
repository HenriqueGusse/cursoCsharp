using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int senha;
            bool correto = false;

           
            while(correto == false) { 
                Console.Write("Digite sua senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha == 2002) {
                correto = true;
                } else{
                correto = false;
                }

                if (correto == true)
                {
                Console.WriteLine("Acesso Permitido");
                } else{
                Console.WriteLine("Senha Invalida");
                
                }

            }
            Console.ReadLine();

        }
    }
}
