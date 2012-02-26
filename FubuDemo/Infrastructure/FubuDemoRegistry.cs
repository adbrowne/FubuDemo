using FubuMVC.Core;
using FubuMVC.Spark;

namespace FubuDemo.Infrastructure
{
    public class FubuDemoRegistry : FubuRegistry
    {
        public FubuDemoRegistry()
        {
            IncludeDiagnostics(true);

            Actions.IncludeClassesSuffixedWithController();

            this.UseSpark();
            Views.TryToAttachWithDefaultConventions();
        }
    }
}