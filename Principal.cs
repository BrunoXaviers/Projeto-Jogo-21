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
PASSAR DE 21, VENCENDO O JOGO QUEM TIVER UM VALOR MAIOR QUE O OUTRO SEM PASSAR DE 21.
 
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
                Jogo regras = new Jogo();
                Console.WriteLine("BEM-VINDO AO 21");
                Console.WriteLine("O JOGO CONSISTE EM DOIS JOGADORES, ONDE CADA UM DELES RECEBE DUAS CARTAS");
                Console.WriteLine("NO COMEÇO DO JOGO, ELES PODEM PEDIR MAIS CARTAS ATE ATINGIR O VALOR DE 21 OU");
                Console.WriteLine("PASSAR DE 21, VENCENDO O JOGO QUEM CHEGAR MAIS PERTO DE 21 SEM PASSAR.");
                Console.WriteLine("1 - INICIAR JOGO");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    Console.Clear();
                    regras.iniciarJogo();
                    regras.continuarJogo();
                }
            }while(opcao != 0);
            
        }
    }
}


