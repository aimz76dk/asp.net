using Microsoft.AspNetCore.Builder;

namespace FirstWebApp
{
    class Startup
    {
        public void Configure(IApplicationBuilder app) {
            app.UseStaticFiles();
        }
    }
}