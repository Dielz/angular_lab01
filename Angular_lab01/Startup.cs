using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_lab01.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Angular_lab01
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //empty comment
        }

        public IConfiguration Configuration { get; } 

        // 
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

           // services.AddDbContext<LabContext>(Options => Options.UseSqlServer("DefaultConnection"));
           //test

            services.AddTransient<HeroesService,HeroesService>();
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
