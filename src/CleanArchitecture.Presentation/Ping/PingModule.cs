using Carter;
using CleanArchitecture.Application.Ping.GetPing;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CleanArchitecture.Presentation.Ping;

public class PingModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("ping", async (ISender sender) =>
        {
            var result = await sender.Send(new GetPingQuery());

            return Results.Ok(new { ping = result });
        });
    }
}