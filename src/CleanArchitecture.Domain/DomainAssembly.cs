using System.Reflection;

namespace CleanArchitecture.Domain;

public static class DomainAssembly
{
    public static readonly Assembly Instance = typeof(DomainAssembly).Assembly;
}