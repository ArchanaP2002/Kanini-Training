﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ApiProject.DataAccess;
using ApiProject.Model_s;
using System;

namespace ApiProject
{
    public class Startup //responsible for configuring the application and service 
    {
        public Startup(IConfiguration configuration) //property holds the application's configuration settings.
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //   this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //method is used to configure the services 
        {
            services.AddDbContext<ProductContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers(); //allows application to handle HTTP requests 

            services.AddSwaggerGen(options => //adds Swagger support
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "API Documentation",
                    Description = "APIs for managing products and categories.",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //configure the HTTP request 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Documentation V1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); //mapping the controllers
            });
        }
    }
}

