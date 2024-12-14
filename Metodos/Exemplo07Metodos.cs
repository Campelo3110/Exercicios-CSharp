using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Metodos
{
    internal class Exemplo07Metodos
    {
        static int Soma(int x)
        {
            return 5 + x;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("A soma dos valores é: " + Soma(5));
        }
    }
}
