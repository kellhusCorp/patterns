using MediatR;
using MediatrExample.Responses;

namespace MediatrExample.Commands;

public class PingCommand : IRequest<PongResponse>
{
}