using System;
using tabuleiro;
namespace xadrez {
    class Tela {


        public static void ImprimirTabuleiro(Tabuleiro tab) {


            for (int i = 0; tab.linhas > i; i++) {

                for (int j = 0; tab.colunas > j; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");

                    }
                    else {
                        Console.Write(tab.peca(i, j) + " - ");

                    }

                }
                Console.WriteLine();
            }
        }
    }
}
