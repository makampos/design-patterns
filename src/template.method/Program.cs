using template.method.Functional;
using static System.Console;
public partial class Program
{
    public static void Main(string[] args)
    {
        var numberOfPlayers = 2;
        int currentPlayer = 0;
        int turn = 1, maxTurns = 10;
      
        void Start()
        {
            WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        bool HaveWinner()
        {
            return turn == maxTurns;
        }
      
        void TakeTurn()
        {
            WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }
      
        int WinningPlayer() {
            return currentPlayer;
        }
      
        GameTemplate.Run(Start, TakeTurn, HaveWinner, WinningPlayer);
    }
}
