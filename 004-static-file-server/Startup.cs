using Microsoft.AspNetCore.Builder;

namespace StaticFileServer
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
    }
}
