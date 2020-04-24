using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(core3._1_mvc_monolith.Areas.Identity.IdentityHostingStartup))]
namespace core3._1_mvc_monolith.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}