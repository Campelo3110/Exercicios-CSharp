using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.ArrayExemplos
{
    internal class Exemplo02Matriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 2, 4, 6, 8 }, { 10, 12, 45, 68 } };

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
