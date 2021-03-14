using System.Reflection;

namespace CleanCodePOC
{
    public static class EfCoreSqlServerDependencyAssemblyProvider
    {
        public static Assembly Get() => typeof(EfCoreSqlServerDependencyAssemblyProvider).Assembly;
    }
}
