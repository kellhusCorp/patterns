using EventMediator.EventArgs;

namespace EventMediator.Mediators;

/// <summary>
/// This is mediator.
/// </summary>
public class Game
{
    public event EventHandler<GameEventArgs> Events;

    public void Fire(GameEventArgs args)
    {
        Events?.Invoke(this, args);
    }
}