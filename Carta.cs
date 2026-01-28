using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Jogo_21
{
    internal class Carta
    {
        public int ValorCarta { get; set; }
        public string CartasString { get; set; }
        public string Naipe { get; set; }
        public Carta(int valorCarta, string cartasString, string naipe)
        {
            ValorCarta = valorCarta;
            CartasString = cartasString;
            Naipe = naipe;
        }
        public override string ToString()
        {
            return $"{CartasString} de {Naipe} ";
        }

        
    }
}
