using Belcorp.API.ViewModels.Mappings;
using Belcorp.Data;
using Belcorp.Data.Abstract;
using Belcorp.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Belcorp.API
{
    public class Startup
    {
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SalesDbContext>(
               options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                );
            services.AddMvc();

            //Register Generic Repository
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // Automapper Configuration
            AutoMapperConfiguracion.Configure();

            //Register services
            services.AddScoped<ICategoryService, CategoryService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Default}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
