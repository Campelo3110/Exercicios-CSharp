using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Metodos
{
    internal class Exemplo04Metodo
    {
        public static void NomeCompleto(string nome)
        {
            Console.WriteLine("Meu nome completo é: " + nome + " Costa dos Santos");
        }
        public static void Main(string[] args) {
            NomeCompleto("Guilherme");
            NomeCompleto("Cristina");
        }
    }
}
