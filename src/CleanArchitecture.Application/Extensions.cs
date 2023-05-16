using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(ApplicationAssembly.Instance));
        services.AddValidatorsFromAssembly(ApplicationAssembly.Instance);

        return services;
    }
}