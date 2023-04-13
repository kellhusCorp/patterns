using Autofac;
using MediatR;
using MediatrExample.Commands;

public static class Program
{
    public static async Task Main()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<Mediator>()
            .As<IMediator>()
            .InstancePerLifetimeScope();

        builder.Register<ServiceFactory>(context =>
        {
            var c = context.Resolve<IComponentContext>();
            return t => c.Resolve(t);
        });

        builder.RegisterAssemblyTypes(typeof(Program).Assembly)
            .AsImplementedInterfaces();

        using (var container = builder.Build())
        {
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"Получили ответ: {response.Timestamp}");
        }
    }
}