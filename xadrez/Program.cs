using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;
namespace xadrez
{
    class Program
    {
        static void Main(string[] args){

            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);


            Console.ReadKey();


        }
    


    }

}
