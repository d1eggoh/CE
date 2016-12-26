using System.Web.Http;

namespace RestCasinoMovil
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
			name: "LoginApi",
				routeTemplate: "api/{controller}/{user}/{pass}/{user_login}/{pass_login}"
			
			);
		}
	}
}
