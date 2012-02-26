using FubuDemo.Service;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;

namespace FubuDemo.Infrastructure
{
    public class FubuDemoContainerRegistry : Registry
    {
        public FubuDemoContainerRegistry()
        {
            For<IMovieService>().LifecycleIs(Lifecycles.GetLifecycle(InstanceScope.Singleton))
                .Use<MovieService>();
        }
    }
}