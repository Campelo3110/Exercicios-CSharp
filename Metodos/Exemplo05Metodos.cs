using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.Metodos
{
    internal class Exemplo05Metodos
    {
        static void NomeIdade(string nome, string sobrenome, int idade)
        {
            Console.WriteLine("Meu dados são: \nNome Completo: " + nome + " " + sobrenome + "\nMinha idade é: " + idade);
        }
        public static void Main(string[] args)
        {
            NomeIdade("Guilherme", "Campelo", 19);
        }
    }
}
