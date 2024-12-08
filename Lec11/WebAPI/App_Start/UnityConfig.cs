using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebAPI.Repositories;
using WebAPI.Services;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IChisteRepository, ChisteRepository>();
            container.RegisterType<IChisteService, ChisteService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}