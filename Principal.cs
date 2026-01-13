using System;
using System.Collections.Generic;
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
            Regras r = new Regras();
            int carta = r.Embaralhar();
            Console.WriteLine(carta);
        }
    }
}


