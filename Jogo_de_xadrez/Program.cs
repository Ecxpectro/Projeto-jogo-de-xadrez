using System;
using tabuleiro;
using xadrez;
namespace Jogo_de_xadrez
{
    class program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

        }
    }
}