using MediatR;

namespace CleanArchitecture.Application.Ping.GetPing;

public sealed record GetPingQuery() : IRequest<string>;