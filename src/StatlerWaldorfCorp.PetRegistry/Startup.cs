using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StatlerWaldorfCorp.PetRegistry.Persistence;

namespace StatlerWaldorfCorp.PetRegistry
{
        public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPetRepository, MemoryPetRepository>();            
	        services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }                
    }
}