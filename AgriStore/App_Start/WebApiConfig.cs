using AgriStore.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AgriStore
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var cors = new EnableCorsAttribute("*", "*", "*");//origins,headers,methods   
            //config.EnableCors(cors);
            // Web API routes
            config.MapHttpAttributeRoutes();
            var container = SetupUnityContainerHelper.SetUpUnityContainer();
            config.DependencyResolver = new UnityResolver(container);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
