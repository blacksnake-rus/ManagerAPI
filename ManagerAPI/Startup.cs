using ManagerAPI.DataCore;
using ManagerAPI.Repository.Implementation;
using ManagerAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace ManagerAPI
{
    public class Startup
    {
        private static string _projectName = "Генератор API";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo { Title = _projectName, Version = "v1" });

                // Для отображения дополнительной документации кода в Swagger
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                opt.IncludeXmlComments(xmlPath);
            });

            var connectionString = Configuration.GetConnectionString("ManagerAPIDbConnectionW");
            services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString), 
                ServiceLifetime.Transient, ServiceLifetime.Transient);
     
            services.AddTransient<IGenericTypeRepository, GenericTypeRepository>();

            
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();

            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", $"{_projectName} V1");
            });
        }
    }
}
