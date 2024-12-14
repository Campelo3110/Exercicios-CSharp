using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.ArrayExemplos
{
    internal class Exemplo04Array
    {
        public static void Main(string[] args)
        {
            string[] nome = { "Ana", "Bruna", "Carolina", "Daiane" };
            foreach (string i in nome)
            {
                Console.WriteLine(i);
            }
        }
    }
}
