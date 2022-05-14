using System;
using xadrez;
using tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {


            try{    
                PartidadeXadrez partida = new PartidadeXadrez();
                
                while(!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);


                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();


                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);


                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);    
                }


            }
            catch (TabuleiroException e){
                System.Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();

        }
    }
}
