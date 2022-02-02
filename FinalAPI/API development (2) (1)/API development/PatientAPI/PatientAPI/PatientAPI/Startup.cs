using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PatientAPI.Models;
using PatientAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI
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

            var connectionString = Configuration.GetConnectionString("PMSDBConnection");
            services.AddDbContext<PMSContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IPatientDemographicInformationService, PatientDemographicInformationService>();
            services.AddScoped<IAllergyService, AllergyService>();
            services.AddScoped<IVitalSignService, VitalSignService>();
            services.AddScoped<IProcedureService, ProcedureService>();
            services.AddScoped<IDiagnosisService, DiagnosisService>();
            services.AddScoped<IDrugService, DrugService>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowOrigin",
                builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("AllowOrigin");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
