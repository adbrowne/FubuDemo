using System.Web;
using FubuDemo.Infrastructure;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace FubuDemo
{
    public class Global : HttpApplication
    {
        public override void Init()
        {
            base.Init();
            FubuApplication
                .For<FubuMoviesRegistry>()
                .StructureMap(() => new Container(
                    new FubuDemoContainerRegistry()
                 ))
                .Bootstrap();
        }
    }
}