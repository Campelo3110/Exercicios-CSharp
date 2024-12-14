using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class ConstrutorExibirBala
    {
        public static void Main(string[] args)
        {
            Bala Ford = new Bala(1,"Honda Civic", "Ford", "Vermelho", 2005);

            Console.WriteLine(Ford.id);
        }
    }
}
