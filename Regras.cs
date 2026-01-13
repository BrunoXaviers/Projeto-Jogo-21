using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cada jogador recebe 2 cartas de inicio e confere suas cartas
E logo após faz o somatório das cartas
Caso ele queira pedir mais uma carta, só tirar mais uma do baralho
Ao final confere quem está mais próximo de 21 sem passar
O jogador que passar de 21 ou chegar mais próximo ao numero vence
 */

namespace Jogo_de_Baralho
{
    internal class Regras:Baralho
    {
        public void TirarCarta(List<int> lista, Stack<int> pilha)
        {
            Random rnd = new Random();
            int cartaAleatoria = rnd.Next(0, lista.Count);
            int cartaRetirada = lista[cartaAleatoria];
            lista.RemoveAt(cartaAleatoria);
            pilha.Push(cartaRetirada);
        }

        public void SortearCarta(Stack<int> pilha)
        {
            Random rnd = new Random();
            int naipeAleatorio = rnd.Next(1, 5);
            switch (naipeAleatorio)
            {
                case 1:
                    TirarCarta(ouros, pilha);
                    break;
                case 2:
                    TirarCarta(paus, pilha);
                    break;
                case 3:
                    TirarCarta(espadas, pilha);
                    break;
                case 4:
                    TirarCarta(copas, pilha);
                    break;
            }
        }

        public void DistribuirCartas()
        {
            for(int i = 0; i < 2; i++)
            {
                SortearCarta(pilhaJogadorUm);
                SortearCarta(pilhaJogadorDois);
            }
        }
    }
}
