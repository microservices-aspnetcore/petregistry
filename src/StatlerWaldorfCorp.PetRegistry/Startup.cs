using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StatlerWaldorfCorp.PetRegistry.Persistence;
using Microsoft.Extensions.Logging;

namespace StatlerWaldorfCorp.PetRegistry
{
    public class Startup 
    {
        private ILogger logger;
        private ILoggerFactory loggerFactory;
        
        public Startup(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
            this.loggerFactory.AddConsole(LogLevel.Information);
            this.loggerFactory.AddDebug();

            this.logger = this.loggerFactory.CreateLogger("Startup");            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPetRepository, MemoryPetRepository>();            
	        services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }                
    }
}