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

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductService, ProductService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}