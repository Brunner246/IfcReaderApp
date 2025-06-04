using IfcReaderApp.Application.Interfaces;
using IfcReaderApp.Application.Services;
using IfcReaderApp.Infrastructure.IfcReader;
using Microsoft.Extensions.DependencyInjection;

namespace IfcReaderApp.IOC;

public static class DependencyInjection
{
    public static IServiceCollection AddIfcReaderServices(this IServiceCollection services)
    {
        services.AddScoped<IIfcFileReader, IfcFileReader>();
        services.AddScoped<IIfcProcessor, IfcProcessor>();
        return services;
    }
}