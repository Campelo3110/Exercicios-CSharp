using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Metodos
{
    internal class Exemplo06Metodos
    {
        static void PaisOrigem(string pais = "Brasil")
        {
            Console.WriteLine("Meu país de origem é : " + pais);
        }

        public static void Main(string[] args)
        {
            PaisOrigem("Argentina");
            PaisOrigem("Chile");
            PaisOrigem();
            PaisOrigem("Guatemala");
        }
    }
}
