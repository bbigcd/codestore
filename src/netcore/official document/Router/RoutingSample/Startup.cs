using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace RoutingSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            var trackPackageRouterHandler = new RouteHandler(context =>
            {
                var routeValues = context.GetRouteData().Values;

                return context.Response.WriteAsync($"Hello! Route values: { string.Join(",", routeValues)}");
            });

            var routeBuilder = new RouteBuilder(app, trackPackageRouterHandler);

            routeBuilder.MapRoute(
                          "Track Package Route",
                          "package/{operation:regex(^track|create$)}/{id:int}");

            routeBuilder.MapRoute("hello/{name}", context =>
            {
                var name = context.GetRouteValue("name");
                return context.Response.WriteAsync($"Hi, {name}");
            });

            var routes = routeBuilder.Build();
            app.UseRouter(routes);

            app.Run(async (context) =>
            {
                var dictionary = new RouteValueDictionary
                {
                    {"operation", "create"},
                    {"id",123}
                };
                var vpc = new VirtualPathContext(context, null, dictionary, "Track Package Route");
                var path = routes.GetVirtualPath(vpc).VirtualPath;
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync("Menu<hr/>");

                await context.Response.WriteAsync($"<a href='{path}'>Create Package 123</a><br/>");
            });
        }
    }
}