using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BakeryShop
{
    public partial class Startup
    {
        private void ConfigureExternalLogin(IServiceCollection services)
        {
            ConfigureGoogleAccount(services);
            ConfigureFacebookAccount(services);
        }



        private void ConfigureFacebookAccount(IServiceCollection services)
        {
            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
        }
        private void ConfigureGoogleAccount(IServiceCollection services)
        {

            services.AddAuthentication().AddGoogle(options =>
            {
                IConfigurationSection googleAuthNSection =
                    Configuration.GetSection("Authentication:Google");

                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            });

        }


    }
}
