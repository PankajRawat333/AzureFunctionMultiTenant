using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(FunctionApp8.Startup))]
namespace FunctionApp8
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {

            builder.Services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddScoped<ITenantProvider, TenantProvider>();
            builder.Services.AddScoped<IDataService>(service =>
            {
                var tenantProvider = service.GetRequiredService<ITenantProvider>();
                return new DataService(tenantProvider.GetTenant());
            });
            builder.Services.AddScoped<ICustomService, CustomService>();
        }
    }
}
