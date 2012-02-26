using FubuDemo.Service;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;

namespace FubuDemo.Infrastructure
{
    public class ContainerRegistry : Registry
    {
        public ContainerRegistry()
        {
            For<IMovieService>().LifecycleIs(Lifecycles.GetLifecycle(InstanceScope.Singleton))
                .Use<MovieService>();
        }
    }
}