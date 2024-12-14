using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class Cadastramento
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cadastramento de comuptador\n");
            
            Console.WriteLine("Informe o nome do computador\n");

            Computador computador = new Computador();
            Console.WriteLine("O Id do computador é " + computador.id);
            Console.WriteLine("O Marca do computador é " + computador.marca);
            Console.WriteLine("O Fabricante do computador é " + computador.fabricante);
            Console.WriteLine("O Processador do computador é " + computador.processador);
            Console.WriteLine("O Memoria Ram do computador é " + computador.memoriaRam);
            Console.WriteLine("O Armazenamento do computador é " + computador.armazenamento);
            Console.WriteLine("O Sistema Operacional do computador é " + computador.sistemaOperacional);
            Console.WriteLine("O Preço do computador é " + computador.preco);
        }
    }
}
