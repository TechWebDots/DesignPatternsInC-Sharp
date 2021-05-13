using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsInC_Sharp.SimpleFactoryPattern;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DesignPatternsInC_Sharp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("*** TechWebDots: Simple Factory Pattern Demo***\n\n");
                    IAnimal preferredType = null;
                    ISimpleFactory simpleFactory = new SimpleFactory();
                    #region The code region that will vary based on userspreference
                    await context.Response.WriteAsync("Factory can accept (0 for Dog, 1 for Tiger)\n\n");
                    await context.Response.WriteAsync("Passing (0 for Dog) to Create Dog Animal\n\n");
                    preferredType = simpleFactory.CreateAnimal(0);
                    #endregion
                    await context.Response.WriteAsync("Dog Animal created and Getting Dog Animal Features\n\n");
                    #region The codes that do not change frequently
                    preferredType.Speak(context);
                    preferredType.Action(context);
                    #endregion
                    await context.Response.WriteAsync("\n");
                });
            });
        }
    }
}
