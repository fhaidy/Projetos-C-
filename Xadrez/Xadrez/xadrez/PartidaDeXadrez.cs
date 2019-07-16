using System.Collections.Generic;
using tabuleiro;
namespace xadrez {
    class PartidaDeXadrez {
        public Tabuleiro Tabuleiro{ get; private set; }
        public bool Terminada { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;

        public PartidaDeXadrez() {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            IniciarTabuleiro();
        }

        public void ColocarNovaPeca(char coluna, int linha, Peca peca) {
            Tabuleiro.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            Pecas.Add(peca);
        }

        private void IniciarTabuleiro() {

            ColocarNovaPeca('a', 1, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('h', 1, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branca));

            ColocarNovaPeca('d', 8, new Rei(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('a', 8, new Torre(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('h', 8, new Torre(Tabuleiro, Cor.Preta));

        }

        public void ExecutarMovimento(Posicao origem, Posicao destino) {
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(p, destino);

            if(pecaCapturada != null) {
                Capturadas.Add(pecaCapturada);
            }
        }

        public HashSet<Peca> RetornaPecasCapturadas (Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca peca in Capturadas) {
                if(peca.Cor == cor) {
                    aux.Add(peca);
                }
            }
            return aux;
        }

        public HashSet<Peca> RetornaPecasEmJogo(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca peca in Capturadas) {
                if (peca.Cor == cor) {
                    aux.Add(peca);
                }
            }
            aux.ExceptWith(RetornaPecasCapturadas(cor));
            return aux;
        }

        public void RealizaJogada(Posicao origem, Posicao destino) {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudaJogador();


        }

        private void MudaJogador() {
            if(JogadorAtual == Cor.Branca) {
                JogadorAtual = Cor.Preta;
            } else {
                JogadorAtual = Cor.Branca;
            }
        }

        public void ValidaOrigem(Posicao pos) {
            if(Tabuleiro.RetornaPeca(pos) == null) {
                throw new TabuleiroException("Não existe peça na posição escolhida !");
            }

            if(JogadorAtual != Tabuleiro.RetornaPeca(pos).Cor) {
                throw new TabuleiroException("A peça escolhida não é sua !");
            }

            if (!Tabuleiro.RetornaPeca(pos).ExisteMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possíveis para esta peça");
            }
        }

        public void ValidaDestino (Posicao origem, Posicao destino) {
            if (!Tabuleiro.RetornaPeca(origem).PodeMoverPara(destino)) {
                throw new TabuleiroException("Esta peça não pode mover para o destino indicado");
            }
        }

       
    }
}
