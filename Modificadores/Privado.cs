using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Modificadores
{
    internal class Privado
    {
        private string cor = "Azul";

        public static void Main(string[] args)
        {
            Privado herby = new Privado();
            Console.WriteLine("A cor do carro do Macedo é: " + herby.cor);
        }
    }
}
