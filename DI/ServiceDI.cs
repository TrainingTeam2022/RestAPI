using TemplateRestAPI.IRepositories;
using TemplateRestAPI.IServices;
using TemplateRestAPI.Repositories;
using TemplateRestAPI.Services;

namespace TemplateRestAPI.DI
{
    public static class ServiceDI
    {
        public static void ConfigServiceDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            //Account
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();

        }
    }
}
