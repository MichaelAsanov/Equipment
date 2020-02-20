using Equipment.UI.Web.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Equipment.UI.Web.RegisterServices
{
    public static class RegisterServicesExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEquipmentService, EquipmentService>();
        }
    }
}