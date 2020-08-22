using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(Shop.UI.Areas.Identity.IdentityHostingStartup))]
namespace Shop.UI.Areas.Identity
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