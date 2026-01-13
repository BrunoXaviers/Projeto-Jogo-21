using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
O baralho tem 14 possibilidades de valores
A,2,3,4,5,6,7,8,9,10,J,Q,K
Em 4 naipes(Ouros, Paus, Espadas e Copas), ou seja, 56 cartas no total

 */

namespace Jogo_de_Baralho
{
    internal class Baralho
    {
        public List<int> ouros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        public List<int> paus = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        public List<int> espadas = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        public List<int> copas = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        public Stack<int> pilhaJogadorUm = new Stack<int>();
        public Stack<int> pilhaJogadorDois = new Stack<int>();
    }
}
