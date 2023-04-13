using EventMediator.EventArgs;

public class PlayerScoredEventArgs : GameEventArgs
{
    public string PlayerName;

    public int GoalsScoredSoFar;

    public PlayerScoredEventArgs(string playerName, int goalsScoredSoFar)
    {
        PlayerName = playerName;
        GoalsScoredSoFar = goalsScoredSoFar;
    }

    public override void Print()
    {
        Console.WriteLine($"{PlayerName} забил гол! " +
                          $"всего {GoalsScoredSoFar} голов");
    }
}