using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ParcialPrograXDatos.Equipos;
using ParcialPrograXRepository;
using ParcialPrograXRepository.Core;
using ParcialPrograXRepository.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ParcialPrograX
{
    public class Startup
    {

        public const string ConnectionString = "Server=localhost;Database=ParcialPrograX;Trusted_Connection=True;";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


            services
                  .AddEntityFrameworkSqlServer()
                  .AddDbContext<ParcialDbContext>((serviceProvider, options) =>
                      options.UseSqlServer(ConnectionString)
                             .UseInternalServiceProvider(serviceProvider));

            
            // Referencia a los servicios
            services.AddScoped<IEquipoRepository, EquipoRepository>();
            services.AddTransient<IEquipo, EquipoServicio>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
        
    }
}
