using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Playground.API
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
            var token = context.Request.Query["token"];
            if (token == "111")
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync(token);
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}