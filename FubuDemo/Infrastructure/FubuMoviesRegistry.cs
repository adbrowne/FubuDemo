using FubuMVC.Core;
using FubuMVC.Spark;

namespace FubuDemo.Infrastructure
{
    public class FubuMoviesRegistry : FubuRegistry
    {
        public FubuMoviesRegistry()
        {
            IncludeDiagnostics(true);

            Actions.IncludeClassesSuffixedWithController();

            this.UseSpark();
            Views.TryToAttachWithDefaultConventions();
        }
    }
}