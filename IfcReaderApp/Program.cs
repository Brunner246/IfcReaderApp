using IfcReaderApp.Application.Interfaces;
using IfcReaderApp.Infrastructure.IfcReader;
using IfcReaderApp.Application.Services;
using IfcReaderApp.IOC;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddIfcReaderServices();

var provider = services.BuildServiceProvider();

var processor = provider.GetRequiredService<IIfcProcessor>();
await processor.ProcessAsync("C:\\Users\\brunn\\Downloads\\Tragwerk.ifc");