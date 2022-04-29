using AmcrestMQTT.Models;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmcrestMQTT

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Amcrest to MQTT", Version = "v1" });


            });
            services.AddHttpClient();



            //appSettings.Bind(options);
            var dataFolder = Configuration.GetValue<string>("DataFolder");
            var optionsText = System.IO.File.ReadAllText(System.IO.Path.Combine(dataFolder, "options.json"));
            var options = System.Text.Json.JsonSerializer.Deserialize<Settings>(optionsText, new System.Text.Json.JsonSerializerOptions() {  PropertyNameCaseInsensitive=true});

            services.AddSingleton(options);
            services.AddTransient<AmcrestToMqttWorker>();

            services.AddHostedService<MQTTWorker>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var swaggerPath = "swagger/v1/swagger.json";
            app.UseSwaggerUI(c =>
            {
//#if !DEBUG
                c.SwaggerEndpoint(swaggerPath, "Amcrest to MQTT v1");
                c.RoutePrefix = "";
//#endif
            });
            app.UseSwagger(c =>
            {
//#if !DEBUG
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
                {
                    var ingressPath = httpReq.Headers["X-Ingress-Path"].FirstOrDefault();
                    if (String.IsNullOrEmpty(ingressPath))
                    {
                        ingressPath = $"{httpReq.Scheme}://{httpReq.Host}";
                    }
                    Console.WriteLine("X-Ingress-Path=" + httpReq.Headers["X-Ingress-Path"].FirstOrDefault());

                    swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer
                 { Url = ingressPath}  };
                });
//#endif
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }

       

    }
}
