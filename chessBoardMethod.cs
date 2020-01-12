using System;

namespace MakeChaseboard {
    class Program {
        static void Main(string[] args) 
        {
            MakeChessBoard();
        }
        public static void MakeChessBoard() 
        {
            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0) 
                    {
                        Console.Write("X");
                        Console.Write("O");
                    }
                    else 
                    {
                        Console.Write("O");
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
