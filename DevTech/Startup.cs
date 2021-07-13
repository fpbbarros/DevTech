
using DevTech.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DevTech
{
    public class Startup
    {
        

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
            
            .AddJsonOptions(options => 
            options.JsonSerializerOptions.PropertyNamingPolicy = null

            
            );

            services.AddTransient<IUsuarioRepository, UsuarioReposutory>();

        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
