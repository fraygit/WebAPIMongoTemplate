using System.Web.Http;
using WebActivatorEx;
using webAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace webAPI
{
	public class SwaggerConfig
	{
		public static void Register()
		{
			var thisAssembly = typeof(SwaggerConfig).Assembly;

			GlobalConfiguration.Configuration
				.EnableSwagger(c => { c.SingleApiVersion("v1", "webAPI"); })
				.EnableSwaggerUi(c => { });
		}
	}
}
