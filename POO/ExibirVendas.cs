using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class ExibirVendas
    {
        public static void Main(string[] args)
        {
            VendasCarro Ford = new VendasCarro();
            Ford.modeloCarro = "Mustang";
            Ford.corCarro = "Azul";
            Ford.anoCarro = 1969;
            Ford.fabricanteCarro = "Ford";
            Ford.tamanhoRoda = 16;

            VendasCarro Byd = new VendasCarro();
            Byd.modeloCarro = "Han";
            Byd.corCarro = "Preto";
            Byd.anoCarro = 2023;
            Byd.fabricanteCarro = "Byd";
            Byd.tamanhoRoda = 16;


            Console.WriteLine(Ford.modeloCarro);
            Console.WriteLine(Ford.corCarro);
            Console.WriteLine(Ford.anoCarro);
            Console.WriteLine(Ford.fabricanteCarro);
            Console.WriteLine(Ford.tamanhoRoda);
            Ford.ExibirMensagem();

            Console.WriteLine("");
            Console.WriteLine(Byd.modeloCarro);
            Console.WriteLine(Byd.corCarro);
            Console.WriteLine(Byd.anoCarro);
            Console.WriteLine(Byd.fabricanteCarro);
            Console.WriteLine(Byd.tamanhoRoda);
            Byd.ExibirMensagem();


        }
    }
}
