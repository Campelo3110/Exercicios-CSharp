using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Metodos
{
    internal class Exemplo03Metodos
    {
        public static void Main(string[] args)
        {
            Nome();
            Idade();
        }

        static void Nome()
        {
            Console.WriteLine("Jailson Costa dos Santos");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        static void Idade()
        {

            Console.WriteLine("Minha idade é 39");
        }
    }
    
}
