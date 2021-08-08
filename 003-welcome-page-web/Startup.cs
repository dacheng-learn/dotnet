using Microsoft.AspNetCore.Builder;

namespace WelcomePageWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
