using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo12
    {
        public static void Main(string[] args)
        {

            for(int i = 1; i <=2; i++)
            {
                Console.WriteLine("\nItem: " + i);

                int inicio = (i == 2) ? 4 : 1; 
                int fim = (i == 2) ? 6 : 3;

                for (int j = inicio; j <= fim; j++)
                {
                    Console.WriteLine("Sub Item: " + j);
                }
            }
        }
    }
}
