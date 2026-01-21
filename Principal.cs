using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************
                    JOGO 21
 
 O JOGO CONSISTE EM DOIS JOGADORES, ONDE CADA UM DELES RECEBE DUAS CARTAS
NO COMEÇO DO JOGO, ELES PODEM PEDIR MAIS CARTAS ATE ATINGIR O VALOR DE 21 OU
PASSAR DE 21, VENCENDO O JOGO QUEM CHEGAR MAIS PERTO DE 21 SEM PASSAR.
 
- NESSE MODELO TEREMOS O JOGADOR CONTRA O JOGADOR
- CADA JOGADOR RECEBE DUAS CARTAS INICIAIS

 ******************************************************/
namespace Jogo_de_Baralho
{
    public class Principal
    {
        public static void Main()
        {
            menu();
        }


        public static void menu()
        {
            int opcao = 0;
            do
            {
                Regras regras = new Regras();
                Console.WriteLine("BEM-VINDO AO 21");
                Console.WriteLine("O JOGO CONSISTE EM DOIS JOGADORES, ONDE CADA UM DELES RECEBE DUAS CARTAS");
                Console.WriteLine("NO COMEÇO DO JOGO, ELES PODEM PEDIR MAIS CARTAS ATE ATINGIR O VALOR DE 21 OU");
                Console.WriteLine("PASSAR DE 21, VENCENDO O JOGO QUEM CHEGAR MAIS PERTO DE 21 SEM PASSAR.");
                Console.WriteLine("1 - INICIAR JOGO");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                int jogo = 0;
                do
                {
                    regras.iniciarJogo();
                    regras.continuarJogo();
                } while (jogo != 0);
            }while(opcao != 0);
            
        }
    }
}


