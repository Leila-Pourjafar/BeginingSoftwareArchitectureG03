using HouseRent.Core.ApplicationServices.Contracts;
using HouseRent.Infra.SimpleDateTime;
using Microsoft.Extensions.DependencyInjection;

namespace HouseRent.Infra.Extentions.DependencyInjection;
public static class SimpleDateTimeRegistrer
{
    public static IServiceCollection RegisterSimpleDateTimeService(this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
