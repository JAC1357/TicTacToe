using TicTacToe;

Board board = new Board();
Player player1 = new Player(Player.PlayerCharacters.X);
Player player2 = new Player(Player.PlayerCharacters.O);
int totalTurns = 9;

Console.WriteLine($"Player 1 is charater: {player1.PlayerCharacter}\n" +
    $"Player 2 is chracter: {player2.PlayerCharacter}\n");
while (totalTurns > 0)
{
    board.PrintBoard(board.Matrix);
    Console.ForegroundColor = ConsoleColor.Red;
    totalTurns = board.FillCell(board.Matrix, player1, totalTurns);
    if (player1.CheckForWin(player1, board))
    {
        Console.WriteLine($"You win {player1.PlayerCharacter}!!!");
        break;
    }

    Console.ForegroundColor = ConsoleColor.Blue;
    totalTurns = board.FillCell(board.Matrix, player2, totalTurns);
    if (player1.CheckForWin(player1, board))
    {
        Console.WriteLine($"You win {player2.PlayerCharacter}!!!");
        break;
    }

    Console.ForegroundColor = ConsoleColor.White;

    totalTurns--;
}
