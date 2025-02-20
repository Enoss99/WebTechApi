using courses;
using EcoApiEscen.Database;
using EcoApiEscen.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EcoApiEscen {
    internal class Startup {
        private static readonly string MyCors = "MyCorsConfig";

        public Startup(IConfiguration configuration) { Configuration = configuration; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddCors(options => {
                options.AddPolicy(MyCors, builder => {
                    builder.AllowAnyHeader();
                    builder.AllowAnyMethod();
                    builder.AllowAnyOrigin();
                });
            });

            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "EcoApiEscen", Version = "v1" }); });
            services.AddDbContext<EcoDbContext>();

            services.AddScoped<IProductService, ProductService>(); // Add the service to DI
            services.AddScoped<IPrice, PriceService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EcoApiEscen v1"));
            }

            // app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors(MyCors);
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}