
using EventMediator.Entities;
using EventMediator.Mediators;

static class Program
{
    static void Main()
    {
        var game = new Game();
        var player = new Player("Roman", game);
        var coach = new Coach(game);
        
        player.Score();
        player.Score();
        player.Score();
    }
}