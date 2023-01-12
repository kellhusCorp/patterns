namespace Multiton;

public class Server
{
    private Server()
    {
        
    }

    public static Server Get(ServerType serverType)
    {
        if (instances.ContainsKey(serverType))
            return instances[serverType];

        var instance = new Server();
        instances[serverType] = instance;

        return instance;
    }
    
    private static readonly Dictionary<ServerType, Server>
        instances = new();
}