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
Em 4 naipes(Ouros, Paus, Espadas e Copas), ou seja, 52 cartas no total
 */

namespace Projeto_Jogo_21
{
    internal class Baralho
    {
        Random rnd = new Random();
        public List<Carta> baralho = new List<Carta>();

        public void comecarJogo()
        {
            baralho.Clear();

            string[] naipes = { "Ouros", "Paus", "Espadas", "Copas" };
            foreach(var naipe in naipes)
            {
                baralho.Add(new Carta(1, "A", naipe));

                for(int i = 2; i <= 10; i++)    
                    baralho.Add(new Carta(i, i.ToString(), naipe));

                baralho.Add(new Carta(10, "J", naipe));
                baralho.Add(new Carta(10, "Q", naipe));
                baralho.Add(new Carta(10, "K", naipe));
            }
        }

        
        public Carta comprarCarta()
        {
            int valorAleatorio = rnd.Next(0, baralho.Count);
            Carta carta = baralho[valorAleatorio];
            baralho.RemoveAt(valorAleatorio);
            return carta;
        }
    }
}
