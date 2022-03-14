using System;
using tabuleiro;
namespace Jogo_de_xadrez
{
    class program
    {
        static void Main(string[] args)
        {
          Tabuleiro tab = new Tabuleiro(8, 8);
          Tela.imprimirTabuleiro(tab);
            

        }
    }
}