using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Playground.Data;
using Playground.Data.Repositories;

namespace Playground.API
{
    public class Startup
    {
        IWebHostEnvironment _env;
        private IConfiguration Configuration { get; set; }

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            Configuration = configuration;
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddControllers();
            services.AddDbContext<WebApiDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString, b =>
                {

                    b.MigrationsAssembly("Playground.API");
                    b.EnableRetryOnFailure();
                });
                
            });
            services.AddScoped<IRepository<Employee>, EmployeeRepository>();//teest why do we need it
            services.AddScoped<IRepository<Customer>, CustomerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(
                endpoints =>
                {
                    endpoints.MapControllers();
                    endpoints.MapGet("/mapget",
                        async context => { await context.Response.WriteAsync("Hello mapget"); });
                }
            );
            app.Run(context => context.Response.WriteAsync("response"));
        }
    }
}