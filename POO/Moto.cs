using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class Moto
    {
        public string model;
        public string cor;
        public int ano;

        public Moto(string modelMoto,  string corMoto, int anoMoto)
        {
            model = modelMoto;
            cor = corMoto;
            ano = anoMoto;
        }

        public static void Main(string[] args)
        {
            Moto minhaMoto = new Moto("dadsa","asasa",250);

            Console.WriteLine(minhaMoto.model + " " + minhaMoto.cor + " " + minhaMoto.ano);
        }
    }
}
