using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        public readonly Player.PlayerCharacters[,] Matrix = new Player.PlayerCharacters[3, 3] { { Player.PlayerCharacters.E, Player.PlayerCharacters.E, Player.PlayerCharacters.E }, { Player.PlayerCharacters.E, Player.PlayerCharacters.E, Player.PlayerCharacters.E }, { Player.PlayerCharacters.E, Player.PlayerCharacters.E, Player.PlayerCharacters.E } };


        public int FillCell(Player.PlayerCharacters[,] board, Player player, int turnCount)
        {
            PrintBoard(board);
            int choice = -1;
            bool cellFilled = true;
            (int row, int col) position;
            int row = 0;
            int col = 0;
            (Player.PlayerCharacters[,], int, int) cellToFill = (board, row, col);
            while (cellFilled)//choice < 1 || choice > 9) //goes till selected number 
            {
                Console.WriteLine($"{player.PlayerCharacter} Use Number pad to make selection (1-9): ");
                string? playerChoice = Console.ReadLine() ?? "-1";
                choice = Convert.ToInt32(playerChoice);
                position = TurnNumberToLocation(choice);
                if (choice < 0 || choice > 9)
                    Console.WriteLine("Please make valid selection.");
                else
                {
                    switch (choice)
                    {
                        case 7:
                            if (CheckIfCellEmptyOrTaken(board, position.row, position.col, player))
                            { 
                            board[0, 1] = player.PlayerCharacter;
                            cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 8:
                            if (CheckIfCellEmptyOrTaken(board, 0, 1, player))
                            { 
                                board[0, 1] = player.PlayerCharacter;
                            cellFilled = false;
                    }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 9:
                            if (CheckIfCellEmptyOrTaken(board, 0, 2, player))
                            { 
                                board[0, 2] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 4:
                            if (CheckIfCellEmptyOrTaken(board, 1, 0, player))
                            { 
                                board[1, 0] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 5:
                            if (CheckIfCellEmptyOrTaken(board, 1, 1, player))
                            { 
                                board[1, 1] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 6:
                            if (CheckIfCellEmptyOrTaken(board, 1, 2, player))
                            { 
                                board[1, 2] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 1:
                            if (CheckIfCellEmptyOrTaken(board, 2, 0, player))
                            { 
                                board[2, 0] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 2:
                            if (CheckIfCellEmptyOrTaken(board, 2, 1, player))
                            { 
                                board[2, 1] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        case 3:
                            if (CheckIfCellEmptyOrTaken(board, 2, 2, player))
                            { 
                                board[2, 2] = player.PlayerCharacter;
                                cellFilled = false;
                            }
                            else
                            {
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            }
                            break;
                        default:
                                Console.WriteLine($"Entry was invalid please use number pad to make selection:");
                                turnCount++;
                            break;
                    }
                    //cellFilled = false;
                }
            }
            return turnCount;

        }

        public bool CheckIfCellEmptyOrTaken(Player.PlayerCharacters[,] board, int row, int column, Player player)
        {
            if (board[row, column] == Player.PlayerCharacters.E)
            {
                board[row, column] = player.PlayerCharacter;
                return true;
            }
            else
                return false;
        }

        public (int, int) TurnNumberToLocation(int userSelectedNumber)
        {
            (int row, int col) position = (0, 0);
            switch (userSelectedNumber)
            {
                case 7:
                    position = (0, 0);
                    break;
                case 8:
                    position = (0, 1);
                    break;
                case 9:
                    position = (0, 2);
                    break;
                case 4:
                    position = (1, 0);
                    break;
                case 5:
                    position = (1, 1);
                    break;
                case 6:
                    position = (1, 2);
                    break;
                case 1:
                    position = (2, 0);
                    break;
                case 2:
                    position = (2, 1);
                    break;
                case 3:
                    position = (2, 2);
                    break;
            }
            return position;
        }

        public void PrintCell(Player.PlayerCharacters[,] board, int row, int col)
        {
            if (board[row, col] == Player.PlayerCharacters.E)
            {
                Console.WriteLine($"  ");
            }
            else if (board[row, col] == Player.PlayerCharacters.X)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {board[0, 0]} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (board[row, col] == Player.PlayerCharacters.O)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" {board[0, 0]} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void PrintBoard(Player.PlayerCharacters[,] board)
        {
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]}\n" +
                $"---+---+---\n" +
                $" {board[1, 0]} | {board[1, 1]} | {board[1, 2]}\n" +
                $"---+---+---\n" +
                $" {board[2, 0]} | {board[2, 1]} | {board[2, 2]}\n");
        }
    }
}
