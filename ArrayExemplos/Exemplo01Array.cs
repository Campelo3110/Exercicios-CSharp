using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.ArrayExemplos
{
    internal class Exemplo01Array
    {
        public static void Main(string[] args)
        {
            string[] carro = { "uno", "passat", "veloster", "gol" };
            Console.WriteLine(carro[1]);
            carro[1] = "Corolla";
            Console.WriteLine(carro[1]);
            Console.WriteLine(carro.Length);
        }
    }
}
