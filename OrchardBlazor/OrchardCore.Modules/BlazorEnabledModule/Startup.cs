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
            // Registers services required for server-side rendering and add services to support rendering interactive server components in a razor components
            services.AddRazorComponents().AddInteractiveServerComponents();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            // Add anti forgery support
            builder.UseAntiforgery();

            // Map the razor components with a reference to the App.razor from the Components folder
            routes.MapRazorComponents<App>().AddInteractiveServerRenderMode();

            // Register the MVC route to the home controller of this module
            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "BlazorEnabledModule",
                pattern: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}
