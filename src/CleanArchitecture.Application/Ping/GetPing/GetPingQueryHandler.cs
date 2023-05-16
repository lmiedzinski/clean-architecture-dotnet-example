using MediatR;

namespace CleanArchitecture.Application.Ping.GetPing;

public class GetPingQueryHandler : IRequestHandler<GetPingQuery, string>
{
    public async Task<string> Handle(GetPingQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult("pong");
    }
}