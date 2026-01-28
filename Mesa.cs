using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Jogo_21
{

    internal class Mesa
    {
        Jogador jogadorUm = new Jogador("");
        Jogador jogadorDois = new Jogador("");
        Jogo jogo = new Jogo();

        public void nomeJogadores()
        {
            Console.WriteLine("Digite o nome do Jogador 1: ");
            string nome1 = Console.ReadLine();
            jogadorUm.Nome = nome1;
            Console.WriteLine("Digite o nome do Jogador 2: ");
            string nome2 = Console.ReadLine();
            jogadorDois.Nome = nome2;
            Console.Clear();
        }

        public void iniciarJogo()
        {
            nomeJogadores();
            jogo.distribuirCartas(jogadorUm, jogadorDois);
            Console.WriteLine($"1 - {jogadorUm.Nome}");
            Console.WriteLine($"Cartas de {jogadorUm.Nome}");
            jogadorUm.mostrarCartas();
            Console.WriteLine($"Soma das cartas = {jogo.somarCartas(jogadorUm)}");
            Console.WriteLine("===================================================");
            Console.WriteLine($"2 - {jogadorDois.Nome}");
            Console.WriteLine($"Cartas de {jogadorUm.Nome}");
            jogadorDois.mostrarCartas();
            Console.WriteLine($"Soma das cartas = {jogo.somarCartas(jogadorDois)}");
        }

        public void continuarJogo()
        {
            int opcao1 = 0, opcao2 = 0;
            do
            {
                Console.WriteLine($"JOGADOR {jogadorUm.Nome}, VOCÊ SOMOU {jogo.somarCartas(jogadorUm)}, DESEJA MAIS UMA CARTA? (0 - NÃO / 1 - SIM)");
                opcao1 = int.Parse(Console.ReadLine());
                if (opcao1 == 1)
                {
                    jogo.tirarCarta(jogadorUm);
                    jogadorUm.mostrarCartas();
                    Console.WriteLine($"Soma das cartas = {jogo.somarCartas(jogadorUm)}");
                    if (jogo.verificarEstouro(jogadorUm))
                    {
                        Console.WriteLine("Você estourou! Fim de jogo.");
                        opcao1 = 0;
                    }
                }
            } while (opcao1 != 0);

            do
            {
                Console.WriteLine($"JOGADOR {jogadorDois.Nome}, VOCÊ SOMOU {jogo.somarCartas(jogadorDois)}, DESEJA MAIS UMA CARTA? (0 - NÃO / 1 - SIM)");
                opcao2 = int.Parse(Console.ReadLine());
                if (opcao2 == 1)
                {
                    jogo.tirarCarta(jogadorDois);
                    jogadorDois.mostrarCartas();
                    Console.WriteLine($"Soma das cartas = {jogo.somarCartas(jogadorDois)}");
                    if (jogo.verificarEstouro(jogadorDois))
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
            Console.WriteLine($"A soma das cartas do Jogador {jogadorUm.Nome} é: " + jogo.somarCartas(jogadorUm));
            Console.WriteLine($"A soma das cartas do Jogador {jogadorDois.Nome} é: " + jogo.somarCartas(jogadorDois));

            int vencedor = jogo.compararJogadores(jogadorUm, jogadorDois);
            if (vencedor == 1)
            {
                Console.WriteLine("Portanto, o vencedor é o Jogador: ");
                Console.WriteLine($"{jogadorUm.Nome}");
            }
            else if (vencedor == 2)
            {
                Console.WriteLine("Portanto, o vencedor é o Jogador: ");
                Console.WriteLine($"{jogadorDois.Nome}");
            }
            else if (vencedor == 3) Console.WriteLine("EMPATE");
            else Console.WriteLine("NENHUM JOGADOR VENCEU, AMBOS ESTOURARAM!");
        }
    }
}
