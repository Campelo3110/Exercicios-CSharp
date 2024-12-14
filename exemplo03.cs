using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class exemplo03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("O número digirado é menor que 10");
            }
        }
    }
}
