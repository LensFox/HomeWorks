using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;


namespace _10_ThreeLayerProject.PL.Middleware
{
    public class MyMiddleware
    {
        private readonly RequestDelegate next;
        private static int counter;
        public MyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Debug.WriteLine("HEADERS");
            Debug.WriteLine(context.Response.Headers);
            counter++;
            Debug.WriteLine($"Counter: {counter}");
            await next(context);
        }
    }
}

