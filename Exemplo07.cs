using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            if (idade < 16)
            {
                Console.WriteLine("Não pode votar");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Voto opcional");
            }
            else
            {
                Console.WriteLine("Voto Obrigatório");
            }
        }
    }
}
