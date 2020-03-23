using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingPizza.Client
{
    public class Startup
    {
        //where you configure DI. We're configuring the services
        //that our app depends on
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<OrderState>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
