using Multiton;

static class Program
{
    static void Main()
    {
        var primaryServer = Server.Get(ServerType.Master);
        var backupServer = Server.Get(ServerType.Backup);
    }
}