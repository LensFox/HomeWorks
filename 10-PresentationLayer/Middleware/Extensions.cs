using Microsoft.AspNetCore.Builder;

namespace _10_ThreeLayerProject.PL.Middleware
{
    public static class Extensions
    {
        public static IApplicationBuilder UseMy(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyMiddleware>();
        }
        public static IApplicationBuilder UseLog(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LogMiddleware>();
        }
    }
}
