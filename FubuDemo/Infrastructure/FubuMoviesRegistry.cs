using FubuMVC.Core;

namespace FubuDemo.Infrastructure
{
    public class FubuMoviesRegistry : FubuRegistry
    {
        public FubuMoviesRegistry()
        {
            IncludeDiagnostics(true);
            
        }
    }
}