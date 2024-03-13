using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace zene
{
    internal class Zenek
    {
        string eloado;
        string cim;
        byte hosszPerc;
        byte hosszMasodperc;

        public Zenek(string eloado, string cim, byte hosszPerc, byte hosszMasodperc)
        {
            this.eloado = eloado;
            this.cim = cim;
            this.hosszPerc = hosszPerc;
            this.hosszMasodperc = hosszMasodperc;
        }
        public int Hossz { get => hosszPerc * 60 + hosszMasodperc; }
        public string Eloado { get => eloado; set => eloado = value; }
        public string Cim { get => cim; set => cim = value; }
        public byte HosszPerc { get => hosszPerc; set => hosszPerc = value; }
        public byte HosszMasodperc { get => hosszMasodperc; set => hosszMasodperc = value; }
    }
}
