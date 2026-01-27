using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
O baralho tem 14 possibilidades de valores
A,2,3,4,5,6,7,8,9,10,J,Q,K
Sendo que A vale 1 ponto
J, Q e K valem 10 pontos cada
Em 4 naipes(Ouros, Paus, Espadas e Copas), ou seja, 56 cartas no total
 */

namespace Jogo_de_Baralho
{
    internal class Baralho
    {
        public List<int> ouros = new List<int>();
        public List<int> paus = new List<int>();
        public List<int> espadas = new List<int>();
        public List<int> copas = new List<int>();
        public Stack<int> pilhaJogadorUm = new Stack<int>();
        public Stack<int> pilhaJogadorDois = new Stack<int>();


        public void comecarJogo()
        {
            pilhaJogadorUm.Clear();
            pilhaJogadorDois.Clear();
            ouros.Clear();
            paus.Clear();
            espadas.Clear();
            copas.Clear();
            for (int i = 0; i < 10; i++)
            {
                ouros.Add(i + 1);
                paus.Add(i + 1);
                espadas.Add(i + 1);
                copas.Add(i + 1);
            }
            for (int i = 0; i < 4; i++)
            {
                ouros.Add(10);
                paus.Add(10);
                espadas.Add(10);
                copas.Add(10);
            }
        }
    }
}
