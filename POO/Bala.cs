using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico.POO
{
    internal class Bala
    {
        public int id;
        public string nome;
        public string montadora;
        public string cor;
        public int ano;

        public Bala(int idBala, string nomeBala, string montadoraBala, string corBala, int anoBala)
        {
            id = idBala;
            nome = nomeBala;
            montadora = montadoraBala;
            cor = corBala;
            ano = anoBala;
        }
    }
}