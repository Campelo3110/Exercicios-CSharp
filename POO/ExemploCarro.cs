using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class ExemploCarro
    {
        public static void Main(string[] args)
        {
            Carro palio = new Carro();

            Console.WriteLine("O id do carro é: " + palio.id);
            Console.WriteLine("O nome do carro é: " + palio.nome);
            Console.WriteLine("O montadora do carro é: " + palio.montadora);
            Console.WriteLine("O cor do carro é: " + palio.cor);
            Console.WriteLine("O ano do carro é: " + palio.ano);

            Carro uno = new Carro();

            uno.id = 2;
            uno.nome = "Uno";
            uno.cor = "vermelho";
            uno.ano = 2014;

            Console.WriteLine("O id do carro é: " + uno.id);
            Console.WriteLine("O nome do carro é: " + uno.nome);
            Console.WriteLine("O montadora do carro é: " + uno.montadora);
            Console.WriteLine("O cor do carro é: " + uno.cor);
            Console.WriteLine("O ano do carro é: " + uno.ano);
        }
    }
}
