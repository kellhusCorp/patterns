namespace TemplateMethod;

public abstract class Game
{
    protected readonly int numberOfPlayers;

    public void Run()
    {
        Start();
        while (!HaveWinner)
        {
            TakeTurn();
        }

        Console.WriteLine($"Player {WinningPLayer} wins");
    }

    protected abstract void Start();

    protected abstract void TakeTurn();
    
    protected abstract bool HaveWinner { get; }
    
    protected abstract int WinningPLayer { get; }

    public Game(int numberOfPlayers)
    {
        this.numberOfPlayers = numberOfPlayers;
    }

    protected int currentPlayer;
}

class ChessGame : Game
{
    public ChessGame() : base(2)
    {
    }

    protected override void Start()
    {
        Console.WriteLine($"Starting a game of chess with {numberOfPlayers}");
    }

    protected override void TakeTurn()
    {
        Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
        currentPlayer = (currentPlayer + 1) % numberOfPlayers;
    }

    protected override bool HaveWinner => turn == maxTurns;
    protected override int WinningPLayer => currentPlayer;

    private int turn = 1, maxTurns = 10;
}

public class GameTemplate
{
    public static void Run(
        Action start,
        Action takeTurn,
        Func<bool> haveWinner,
        Func<int> winningPlayer
    )
    {
        start();
        while (!haveWinner())
        {
            takeTurn();
        }

        Console.WriteLine($"Player {winningPlayer()} wins.");
    }
}

static class TemplateMethodExample
{
    static void Main()
    {
        var chess = new ChessGame();
        chess.Run();

        var numberOfPlayers = 2;
        int currentPlayer = 0;
        int turn = 1, maxTurn = 10;

        void Start()
        {
            Console.WriteLine("Starting game from functional template method");
        }

        bool HaveWinner()
        {
            return turn == maxTurn;
        }

        void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }

        int WinningPlayer()
        {
            return currentPlayer;
        }
        
        GameTemplate.Run(
            Start,
            TakeTurn,
            HaveWinner,
            WinningPlayer
        );
    }
}