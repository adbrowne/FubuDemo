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
                                 new Movie{Name = "Rocky Horror Picture Show", Description = "Not Scary"});
                             service.Add(
                                 new Movie{Name = "The Lord of the Rings", Description = "Quite long but worth it"});
                             return service;
                         });
        }
    }
}