using Financeiro.API.Extensions;
using Financeiro.Application.Util;
using Financeiro.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Financeiro.API
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

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "wwwroot";
            });

            services.AddHttpContextAccessor();
            services.AddScoped<IUsuario, Usuario>();

            //api extensions
            services.RegisterDependencyInjection();
            services.AddResponseCompressionProvider();
            services.AddApiVersioningConfiguration();
            services.AddJwtAuthenticationConfiguration(Configuration);
            services.AddSwaggerConfiguration();

            services.AddCors();

            services.AddHealthChecks()
             .AddSqlServer(Configuration.GetConnectionString("DefaultConnection"), name: Configuration.GetValue<string>("DatabaseEnvironment"));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

                app.UseStaticFiles();

                app.UseSpaStaticFiles();

                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });

                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "FINANCEIRO API");
                    c.RoutePrefix = "api/swagger";
                });

                app.UseSpa(spa =>
                {
                    spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "Financeiro-UI");

                    spa.Options.SourcePath = "wwwroot";
                    if (Configuration.GetValue<bool>("UseAngularCliDeveloperServer"))
                        spa.UseProxyToSpaDevelopmentServer(Configuration.GetValue<string>("AngularCliDeveloperServer"));
                });
            }
        }
    }
}
