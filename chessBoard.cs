//This program creates a chess board pattern using a nested for loop, if/else statement and modulo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessBoard {
    class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0) {
                        Console.Write("X");
                        Console.Write("O");
                    }
                    else {
                        Console.Write("O");
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
