using GPS.WinTermConfig.UI.Common;
using GPS.WinTermConfig.UI.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Debug;
using WebWindows.Blazor;

namespace GPS.WinTermConfig.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainViewModel>();
            services.AddTransient<Index>();
            services.AddLogging(builder => {
                builder.AddDebug();
            });
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            var provider = app.Services;

            app.AddComponent<App>("app");
        }
    }
}
