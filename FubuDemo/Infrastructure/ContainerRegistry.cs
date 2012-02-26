using FubuDemo.Core;
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
                .Use(x =>
                         {
                             var service = new MovieService();
                             service.Add(
                                 new Movie{Name = "10 things I hate about you", Description = "Awesome"});
                             service.Add(
                                 new Movie{Name = "Flying Arrows", Description = "Has Ninjas"});
                             return service;
                         });
        }
    }
}