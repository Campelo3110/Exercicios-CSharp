using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.ArrayExemplos
{
    internal class Exemplo03Matriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }, { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28} };

            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.WriteLine(numero[i, j]);
                }
            }
        }
    }
}
