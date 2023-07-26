
//////namespace BookStoreApi
//////{
//////    public class Program
//////    {
//////        public static void Main(string[] args)
//////        {
//////            var builder = WebApplication.CreateBuilder(args);

//////            // Add services to the container.

//////            builder.Services.AddControllers();
//////            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//////            builder.Services.AddEndpointsApiExplorer();
//////            builder.Services.AddSwaggerGen();

//////            var app = builder.Build();

//////            // Configure the HTTP request pipeline.
//////            if (app.Environment.IsDevelopment())
//////            {
//////                app.UseSwagger();
//////                app.UseSwaggerUI();
//////            }

//////            app.UseHttpsRedirection();

//////            app.UseAuthorization();


//////            app.MapControllers();

//////            app.Run();
//////        }
//////    }
//////}


////using Microsoft.AspNetCore.Builder;
////using Microsoft.AspNetCore.Hosting;
////using Microsoft.Extensions.DependencyInjection;
////using Microsoft.Extensions.Hosting;
////using Microsoft.OpenApi.Models;

////namespace BookStoreApi
////{
////    public class Startup
////    {
////        public void ConfigureServices(IServiceCollection services)
////        {
////            services.AddControllers();

////            // Configure Swagger/OpenAPI
////            services.AddEndpointsApiExplorer();
////            services.AddSwaggerGen(c =>
////            {
////                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
////            });
////        }

////        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
////        {
////            if (env.IsDevelopment())
////            {
////                app.UseSwagger();
////                app.UseSwaggerUI(c =>
////                {
////                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
////                });
////            }

////            app.UseHttpsRedirection();
////            app.UseRouting();
////            app.UseAuthorization();

////            app.UseEndpoints(endpoints =>
////            {
////                endpoints.MapControllers();
////            });
////        }
////    }
////}

//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.OpenApi.Models;
//using BookStoreApi.models;
//using BookStoreApi.Data;
//using BookStoreApi.Services;

//namespace BookStoreApi
//{
//    public class Startup
//    {
//        private readonly IConfiguration _configuration;

//        public Startup(IConfiguration configuration)
//        {
//            configuration = configuration;
//        }

//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();

//            // Add DbContext with eager loading
//            services.AddDbContext<BookStoreContext>(options =>
//                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"))
//                    .UseLazyLoadingProxies());

//            // Configure Swagger/OpenAPI
//            services.AddEndpointsApiExplorer();
//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
//            });

//            // Register your services here

//            services.AddScoped<AuthorService>();
//        }

//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseSwagger();
//                app.UseSwaggerUI(c =>
//                {
//                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
//                });
//            }

//            app.UseHttpsRedirection();
//            app.UseRouting();
//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });
//        }
//    }
//}


using BookStoreApi;
using BookStoreApi.Data;
using BookStoreApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BookStoreApi
{
    public class Startup
    {
        private readonly IConfiguration _configurationField;

        public Startup(IConfiguration configuration)
        {
            _configurationField = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Add DbContext with eager loading
            services.AddDbContext<BookStoreContext>(options =>
                options.UseSqlServer(_configurationField.GetConnectionString("DefaultConnection"))
                    .UseLazyLoadingProxies());

            // Configure Swagger/OpenAPI
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
            });

            // Register your services here
            services.AddScoped<AuthorService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
                });
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

/*
 * using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace YourNamespace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices(services =>
                    {
                        services.AddControllers();

                        // Add Swagger
                        services.AddSwaggerGen(c =>
                        {
                            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
                        });
                    })
                    .Configure(app =>
                    {
                        app.UseRouting();
                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });

                        // Enable Swagger UI
                        app.UseSwagger();
                        app.UseSwaggerUI(c =>
                        {
                            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
                        });
                    });
                });
    }
}

 * 
*/