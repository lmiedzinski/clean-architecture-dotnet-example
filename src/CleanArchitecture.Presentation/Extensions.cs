using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presentation;

public static class Extensions
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        return services;
    }
}