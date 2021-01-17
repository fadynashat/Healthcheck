using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

using EducationalStudyAPI.Models;

namespace  EducationalStudyAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<Context>(options =>options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddHealthChecks().AddCheck("self", () => HealthCheckResult.Healthy());
            services.AddHealthChecks().AddSqlServer(Configuration.GetConnectionString("DefaultConnection"));

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
                app.UseCors(builder =>
                  builder
                  .AllowAnyHeader()
                  .AllowAnyOrigin()
                  .AllowCredentials()
                  .AllowAnyMethod());

            app.UseHealthChecks("/health", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            app.UseMvc();
        }
    }
}

