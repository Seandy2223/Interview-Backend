using Microsoft.Extensions.DependencyInjection;

namespace moduit.Base
{
    public static class RegisterFramework
    {
        public static void RegisterDI(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IFeature), typeof(Feature));
            services.AddTransient<IRESTService, RESTService>();
        }
    }
}
