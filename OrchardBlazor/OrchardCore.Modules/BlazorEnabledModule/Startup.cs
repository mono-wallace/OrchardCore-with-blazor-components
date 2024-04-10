using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace BlazorEnabledModule
{
    using BlazorEnabledModule.Components;

    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorComponents().AddInteractiveServerComponents();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            builder.UseAntiforgery();

            routes.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "BlazorEnabledModule",
                pattern: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
