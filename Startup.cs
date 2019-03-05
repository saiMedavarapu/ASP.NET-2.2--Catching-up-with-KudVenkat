using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CrudEmployee
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
//This is the connection which acts as middlware
            app.Use(async (context, next) =>
            {
                //await context.Response.WriteAsync("Hello from first middleware");
                logger.LogInformation("MW1: incomming request");
                await next();
                logger.LogInformation("MW1: outgoing response");
            });

             app.Use(async (context, next) =>
            {
                //await context.Response.WriteAsync("Hello from first middleware");
                logger.LogInformation("MW2: incomming request");
                await next();
                logger.LogInformation("MW2: outgoing response");
            });

            

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MW3: response is handled and produced");
                  logger.LogInformation("MW3: Request Handled");
            });
        }
    }
}
