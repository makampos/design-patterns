namespace template.method.Functional;
using static System.Console;

public static class GameTemplate
{
    public static void Run(
        Action start,
        Action takeTurn,
        Func<bool> haveWinner,
        Func<int> winningPlayer)
    {
        start();
        while (!haveWinner())
            takeTurn();
        WriteLine($"Player {winningPlayer()} wins.");
    }
}