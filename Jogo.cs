using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
Cada jogador recebe 2 cartas de inicio e confere suas cartas
E logo após faz o somatório das cartas
Caso ele queira pedir mais uma carta, só tirar mais uma do baralho
Ao final confere quem tem um somatório maior sem passar de 21
 */

namespace Projeto_Jogo_21
{
    internal class Jogo 
    {
        Baralho baralho = new Baralho();
       
        public void tirarCarta(Jogador jogador)
        {
            Carta carta = baralho.comprarCarta();
            jogador.receberCarta(carta);

        }

        public void distribuirCartas(Jogador pilhaJogadorUm, Jogador pilhaJogadorDois)
        {
            baralho.comecarJogo();
            for (int i = 0; i < 2; i++) {
                Carta cartaJogador = baralho.comprarCarta();
                pilhaJogadorUm.receberCarta(cartaJogador);
                cartaJogador = baralho.comprarCarta();
                pilhaJogadorDois.receberCarta(cartaJogador);
            }
        }

        public int somarCartas(Jogador pilhaJogador)
        {
            int soma = 0;
            foreach (Carta carta in pilhaJogador.mao)
            {
                soma += carta.ValorCarta;
            }
            return soma;

        }

        public bool verificarEstouro(Jogador pilha)
        {
            int soma = somarCartas(pilha);
            if (soma > 21) return true;
            return false;
        }

        public int compararJogadores(Jogador pilha1, Jogador pilha2)
        {

            int soma1 = somarCartas(pilha1);
            int soma2 = somarCartas(pilha2);
            if (verificarEstouro(pilha1) && !verificarEstouro(pilha2)) return 2;

            if (verificarEstouro(pilha2) && !verificarEstouro(pilha1)) return 1;

            if (soma1 > soma2 && !verificarEstouro(pilha1)) return 1;

            else if (soma2 > soma1 && !verificarEstouro(pilha2)) return 2;
            else if (soma1 == soma2 && !verificarEstouro(pilha1) && !verificarEstouro(pilha2))  return 3;
            return 4;
        }
    }
}
