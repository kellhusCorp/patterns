using EventMediator.Mediators;

namespace EventMediator.Entities;

public class Player
{
    private string name;

    private Game game;

    private int goalsScored = 0;
    
    public Player(string name, Game game)
    {
        this.name = name;
        this.game = game;
    }

    public void Score()
    {
        goalsScored++;
        var args = new PlayerScoredEventArgs(name, goalsScored);
        game.Fire(args);
    }
}