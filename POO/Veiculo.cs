using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class Veiculo
    {
        public string marca;
        
        public Veiculo()
        {
            marca = "Mustang";
        }

        public static void Main(string[] args)
        {
            Veiculo Ford = new Veiculo();
            Console.WriteLine(Ford.marca);
        }
    }
}
