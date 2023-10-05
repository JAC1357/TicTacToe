using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public readonly PlayerCharacters PlayerCharacter;

        public Player(PlayerCharacters character)
        {
            PlayerCharacter = character;
        }
        public bool CheckForWin(Player player, Board board)
        {
            //rows
            if (board.Matrix[0, 0] == player.PlayerCharacter && board.Matrix[0, 1] == player.PlayerCharacter && board.Matrix[0, 2] == player.PlayerCharacter) return true;
            else if (board.Matrix[1, 0] == player.PlayerCharacter && board.Matrix[1, 1] == player.PlayerCharacter && board.Matrix[1, 2] == player.PlayerCharacter) return true;
            else if (board.Matrix[2, 0] == player.PlayerCharacter && board.Matrix[2, 1] == player.PlayerCharacter && board.Matrix[2, 2] == player.PlayerCharacter) return true;

            //columns
            else if (board.Matrix[0, 0] == player.PlayerCharacter && board.Matrix[1, 0] == player.PlayerCharacter && board.Matrix[2, 0] == player.PlayerCharacter) return true;
            else if (board.Matrix[0, 1] == player.PlayerCharacter && board.Matrix[1, 1] == player.PlayerCharacter && board.Matrix[2, 1] == player.PlayerCharacter) return true;
            else if (board.Matrix[0, 2] == player.PlayerCharacter && board.Matrix[1, 2] == player.PlayerCharacter && board.Matrix[2, 2] == player.PlayerCharacter) return true;

            //diagonals
            else if (board.Matrix[0, 0] == player.PlayerCharacter && board.Matrix[1, 1] == player.PlayerCharacter && board.Matrix[2, 2] == player.PlayerCharacter) return true;
            else if (board.Matrix[0, 2] == player.PlayerCharacter && board.Matrix[1, 1] == player.PlayerCharacter && board.Matrix[2, 0] == player.PlayerCharacter) return true;
            else 
                return false;
        }

        public enum PlayerCharacters
        {
            E,
            X,
            O,
        }
    }
}
