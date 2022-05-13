using System;
using xadrez;
using tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8,8);

            try{    
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0,0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1,3));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0,2));     

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e){
                System.Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();

        }
    }
}
