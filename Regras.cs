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
        public void tirarCarta(List<int> lista, Stack<int> pilha)
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
                    tirarCarta(ouros, pilha);
                    break;
                case 2:
                    tirarCarta(paus, pilha);
                    break;
                case 3:
                    tirarCarta(espadas, pilha);
                    break;
                case 4:
                    tirarCarta(copas, pilha);
                    break;
            }
        }

        public void distribuirCartas()
        {
            for(int i = 0; i < 2; i++)
            {
                SortearCarta(pilhaJogadorUm);
                SortearCarta(pilhaJogadorDois);
            }
        }

        public void mostrarCartas(Stack<int> pilha)
        {
            foreach (int carta in pilha)
            {
                Console.WriteLine(carta);
            }
        }

        public int somarCartas(Stack<int> pilha)
        {
            int soma = 0;
            foreach(int carta in pilha)
            {
                soma += carta;
            }
            return soma;
        }
        public bool verificarEstouro(Stack<int> pilha)
        {
            int soma = somarCartas(pilha);
            if (soma > 21) return false;
            return true;
        }
    }
}
