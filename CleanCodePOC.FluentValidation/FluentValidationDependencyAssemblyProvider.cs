using System.Reflection;

namespace CleanCodePOC
{
    public static class FluentValidationDependencyAssemblyProvider
    {
        public static Assembly Get() => typeof(FluentValidationDependencyAssemblyProvider).Assembly;
    }
}
