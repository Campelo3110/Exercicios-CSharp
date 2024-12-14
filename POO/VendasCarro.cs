using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class VendasCarro
    {
        public string modeloCarro;
        public string corCarro;
        public int anoCarro;
        public string fabricanteCarro;
        public int tamanhoRoda;

        public void ExibirMensagem()
        {
            Console.WriteLine("Isso é um carro");
        }
    }
}
