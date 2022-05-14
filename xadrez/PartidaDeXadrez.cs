using System;
using tabuleiro;
namespace xadrez{
    class PartidadeXadrez{
        
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidadeXadrez(){
            tab = new Tabuleiro(8,8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPeca();
        }


        public void executarMovimento(Posicao origem, Posicao destino){
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimento();
            Peca pecaCapoturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPeca(){
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaXadrez('c',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaXadrez('d',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaXadrez('e',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaXadrez('e',2).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaXadrez('d',1).toPosicao());

        }

        

    }
}
