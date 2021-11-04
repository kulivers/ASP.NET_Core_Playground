using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Parky_API.Data;

namespace ASP.NET_Core_Playground
{
    public class Startup
    {
        IWebHostEnvironment _env;
        private IConfiguration _config;

        public Startup(IWebHostEnvironment env, IConfiguration config)
        {
            _env = env;
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            try
            {
                services.AddDbContext<ApplicationDataBaseContext>(options => options.UseSqlServer());
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<TokenMiddleware>();
            app.UseRouting();
            app.Map("/index", Index);
            app.UseEndpoints((endpoints) =>
            {
                endpoints.MapGet("/index",
                    async context => { await context.Response.WriteAsync("index endpoint"); });
            });

            app.Run(async (context) => { await context.Response.WriteAsync("response"); });
        }

        private void Index(IApplicationBuilder app)
        {
            app.Run(async context => { await context.Response.WriteAsync("index method"); });
        }

        private static void HandleId(IApplicationBuilder app)
        {
            app.Run(async context => { await context.Response.WriteAsync("id is equal to 5"); });
        }
    }
}