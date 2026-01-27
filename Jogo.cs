using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Cada jogador recebe 2 cartas de inicio e confere suas cartas
E logo após faz o somatório das cartas
Caso ele queira pedir mais uma carta, só tirar mais uma do baralho
Ao final confere quem tem um somatório maior sem passar de 21
 */

namespace Jogo_de_Baralho
{
    internal class Jogo : Baralho
    {
        Random rnd = new Random();
        public void tirarCarta(List<int> lista, Stack<int> pilha)
        {
            int cartaAleatoria = rnd.Next(0, lista.Count);
            int cartaRetirada = lista[cartaAleatoria];
            lista.RemoveAt(cartaAleatoria);
            pilha.Push(cartaRetirada);
        }

        public void sortearCarta(Stack<int> pilha)
        {
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
            if (soma > 21) return true;
            return false;
        }

        public int compararJogadores(Stack<int> pilha1, Stack<int> pilha2)
        {

            int soma1 = somarCartas(pilha1);
            int soma2 = somarCartas(pilha2);
            if(!verificarEstouro(pilha1))
            {
                if(soma1 > soma2) return 1;
            }
            else if(!verificarEstouro(pilha2))
            {
                if(soma2 > soma1) return 2;
            }
            else if(soma1 == soma2 && !verificarEstouro(pilha1) && !verificarEstouro(pilha2)) return 3;
            return 4;
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
            int opcao1 = 0, opcao2 = 0;
            do
            {
                Console.WriteLine("JOGADOR 1, DESEJA MAIS UMA CARTA? (0 - NÃO / 1 - SIM)");
                opcao1 = int.Parse(Console.ReadLine());
                if (opcao1 == 1)
                {
                    sortearCarta(pilhaJogadorUm);
                    mostrarCartas(pilhaJogadorUm);
                    Console.WriteLine($"Soma das cartas = {somarCartas(pilhaJogadorUm)}");
                    if (verificarEstouro(pilhaJogadorUm))
                    {
                        Console.WriteLine("Você estourou! Fim de jogo.");
                        opcao1 = 0;
                    }
                }
            } while (opcao1 != 0);

            do
            {
                Console.WriteLine("JOGADOR 2, DESEJA MAIS UMA CARTA? (0 - NÃO / 1 - SIM)");
                opcao2 = int.Parse(Console.ReadLine());
                if (opcao2 == 1)
                {
                    sortearCarta(pilhaJogadorDois);
                    mostrarCartas(pilhaJogadorDois);
                    Console.WriteLine($"Soma das cartas = {somarCartas(pilhaJogadorDois)}");
                    if (verificarEstouro(pilhaJogadorDois))
                    {
                        Console.WriteLine("Você estourou! Fim de jogo.");
                        opcao2 = 0;
                    }
                }
            } while (opcao2 != 0);
            Console.WriteLine("Resultados...");
            Console.WriteLine("s para continuar");
            string teclaQualquer = Console.ReadLine();
            if (teclaQualquer == "s" || teclaQualquer == "S") resultadoJogo();
        }

        public void resultadoJogo()
        {
            Console.Clear();
            Console.WriteLine("A soma das cartas do Jogador 1 é: " + somarCartas(pilhaJogadorUm));
            Console.WriteLine("A soma das cartas do Jogador 2 é: " + somarCartas(pilhaJogadorDois));

            int vencedor = compararJogadores(pilhaJogadorUm, pilhaJogadorDois);
            if (vencedor == 1)
            {
                Console.WriteLine("Portanto, o vencedor é o Jogador: ");
                Console.WriteLine("JOGADOR 1");
            }
            else if (vencedor == 2)
            {
                Console.WriteLine("Portanto, o vencedor é o Jogador: ");
                Console.WriteLine("JOGADOR 2");
            }
            else if (vencedor == 3) Console.WriteLine("EMPATE");
            else Console.WriteLine("NENHUM JOGADOR VENCEU, AMBOS ESTOURARAM!");
        }
    }
}
