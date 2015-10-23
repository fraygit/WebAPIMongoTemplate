using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web;
using System.Web.Http;
using webAppTemplate.MongoData.Interface;
using webAppTemplate.MongoData.Repository;

namespace webAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            container.Register<ICarRepository, CarRepository>(Lifestyle.Scoped);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
