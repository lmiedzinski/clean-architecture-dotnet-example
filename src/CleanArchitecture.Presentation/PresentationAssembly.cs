using System.Reflection;

namespace CleanArchitecture.Presentation;

public static class PresentationAssembly
{
    public static readonly Assembly Instance = typeof(PresentationAssembly).Assembly;
}