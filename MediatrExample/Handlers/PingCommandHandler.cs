using JetBrains.Annotations;
using MediatR;
using MediatrExample.Commands;
using MediatrExample.Responses;

namespace MediatrExample.Handlers;

[UsedImplicitly]
public class PingCommandHandler : IRequestHandler<PingCommand, PongResponse>
{
    public async Task<PongResponse> Handle(PingCommand request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new PongResponse(DateTime.Now))
            .ConfigureAwait(false);
    }
}