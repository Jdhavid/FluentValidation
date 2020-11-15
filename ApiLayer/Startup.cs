using DataLayer;
using DataLayer.Interfaces;
using FluentValidation;
using LogicLayer;
using LogicLayer.Interfaces;
using LogicLayer.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelLayer;
using ModelLayer.Interfaces;

namespace ApiLayer
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
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IPersonData, PersonData>();
            services.AddTransient<IPersonResponse, PersonResponse>();
            services.AddTransient<IValidator<PersonModel>, PersonModelValidator>();
            services.AddTransient<IValidator<PersonRequest>, PersonRequestValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
