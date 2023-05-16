using System.Reflection;

namespace CleanArchitecture.Infrastructure;

public static class InfrastructureAssembly
{
    public static readonly Assembly Instance = typeof(InfrastructureAssembly).Assembly;
}