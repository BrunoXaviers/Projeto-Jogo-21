using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Jogo_21
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public Stack<Carta> mao { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
            mao = new Stack<Carta>();

    }

        public void receberCarta(Carta carta)
        {
            mao.Push(carta);
        }

        public void mostrarCartas()
        {
            foreach (Carta carta in mao)
            {
                Console.WriteLine(carta);
            }
        }

    }
}
