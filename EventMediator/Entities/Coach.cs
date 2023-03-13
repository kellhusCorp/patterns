using EventMediator.Mediators;

namespace EventMediator.Entities;

public class Coach
{
    private Game game;

    public Coach(Game game)
    {
        this.game = game;

        game.Events += (sender, args) =>
        {
            if (args is PlayerScoredEventArgs scored && scored.GoalsScoredSoFar < 3)
            {
                Console.WriteLine($"Тренер сказал: круто {scored.PlayerName}!");
            }
        };
    }
}