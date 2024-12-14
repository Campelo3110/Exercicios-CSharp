using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string? nome = Console.ReadLine();
            Console.WriteLine("Meu nome é " + nome);
        }
    }
}
