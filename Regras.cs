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
    internal class Regras : Baralho
    {
        public void tirarCarta(List<int> lista, Stack<int> pilha)
        {
            Random rnd = new Random();
            int cartaAleatoria = rnd.Next(0, lista.Count);
            int cartaRetirada = lista[cartaAleatoria];
            lista.RemoveAt(cartaAleatoria);
            pilha.Push(cartaRetirada);
        }

        public void sortearCarta(Stack<int> pilha)
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
            comecarJogo();
            for (int i = 0; i < 2; i++)
            {
                sortearCarta(pilhaJogadorUm);
                sortearCarta(pilhaJogadorDois);
            }
        }

        public void mostrarCartas(Stack<int> pilha)
        {
            foreach (int carta in pilha)
            {
                Console.Write(carta + " ");
            }
        }

        public int somarCartas(Stack<int> pilha)
        {
            int soma = 0;
            foreach (int carta in pilha)
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

        public int compararJogadores(Stack<int> pilha1, Stack<int> pilha2)
        {

            int soma1 = somarCartas(pilha1);
            int soma2 = somarCartas(pilha2);
            if (soma1 > soma2) return 1;
            else if(soma2 > soma1) return 2;
            else return 3;
        }

        public void iniciarJogo()
        {
            distribuirCartas();
            Console.WriteLine("1 - JOGADOR 1");
            mostrarCartas(pilhaJogadorUm);
            Console.WriteLine($"Soma das cartas = {somarCartas(pilhaJogadorUm)}");
            Console.WriteLine();
            Console.WriteLine("2 - JOGADOR 2");
            mostrarCartas(pilhaJogadorDois);
            Console.WriteLine($"Soma das cartas = {somarCartas(pilhaJogadorDois)}");
        }

        public void continuarJogo()
        {
             
        }
    }
}
