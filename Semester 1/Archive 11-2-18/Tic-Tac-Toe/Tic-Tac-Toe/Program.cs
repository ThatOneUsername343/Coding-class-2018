using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        public static char[,] board = new char[3, 3];
        static int space = board.Length;
        
        static void Main(string[] args)
        {
            //Rules and stuff I guess
            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("How to play:");
            Console.WriteLine("X's go first.");
            Console.WriteLine("To input where you want to place your letter at, first indicate the vertical position, then ");
            Console.WriteLine("the horizontal position. For example, top middle position would be 0,1.");
            Console.WriteLine("First player to get three in a row wins.");
            Console.WriteLine("****************************************************");
            Console.WriteLine("");
            Console.WriteLine("What board size do you want? 3x3(1) or 4x4(2)?");
            int Input = int.Parse(Console.ReadLine());

            //Coordinate system and printing x and o and stuff like that i guess
            //3x3 board
            if (Input == 1)
            {
                //Board stuff
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        board[i, j] = ' ';
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("Player 1(x)'s turn.");
                    DrawBoard(board);
                    ProcessTurn(board, 'x');
                    VerifyBoard();

                    Console.WriteLine("Player 2(o)'s turn.");
                    DrawBoard(board);
                    ProcessTurn(board, 'o');
                    VerifyBoard();
                    
                }
            }

            //4x4 board
            if (Input == 2)
            {
                Console.WriteLine("I didn't have enough time to get this working. :(");
                ////Board stuff
                //for (int i = 0; i < 4; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        board[i, j] = ' ';
                //    }
                //}
                //for (int i = 0; i < 9; i++)
                //{
                //    Console.WriteLine("Player 1(x)'s turn.");
                //    DrawBoard(board);
                //    ProcessTurn(board, 'x');
                //    VerifyBoard();

                //    Console.WriteLine("Player 2(o)'s turn.");
                //    DrawBoard(board);
                //    ProcessTurn(board, 'o');
                //    VerifyBoard();
                //}
            }
        }

        //Board renderer
        static void DrawBoard(char[,] Board)
        {
            for (int i = 0; i < Board.GetLength(0 + 1); i++)
            {
                for (int j = 0; j < Board.GetLength(0 + 1); j++)
                {
                    Console.Write("|" + Board[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        //Input or coordinate input or whatever
        static void ProcessTurn(char[,] array, char player)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //TODO: Error check
            array[x, y] = player;
        }

        //Did I won?
        static void VerifyBoard()
        {
            bool didIWon = false;

            //If X wins
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 2] != ' ' ||
                board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 2] != ' ' ||
                board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 2] != ' ' ||
                board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != ' ' ||
                board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[2, 1] != ' ' ||
                board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != ' ' ||
                board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != ' ' ||
                board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != ' ')
            {
                Console.WriteLine("One of y'all just won.");
                System.Environment.Exit(0);
                //Console.ReadLine();
            }

            else
            {
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int k = 0; k < board.GetLength(1); k++)
                    {
                        if (board[i,k] == ' ')
                        {
                            didIWon = true;
                            
                        }
                    }
                }

                if (!didIWon)
                {
                    Console.WriteLine("Congradulations, its a tie game.");
                    System.Environment.Exit(0);

                }
            }
        }
    }
}
