using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.ArrayExemplos
{
    internal class Exemplo06ArrayMetodos
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 5, 1, 8, 9 };
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.Sum());
        }
    }
}
