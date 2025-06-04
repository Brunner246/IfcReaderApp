using IfcReaderApp.Application.Interfaces;
using IfcReaderApp.Domain.Models;
using Xbim.Ifc;

namespace IfcReaderApp.Infrastructure.IfcReader;

public class IfcFileReader : IIfcFileReader
{
    public List<EntityCount> GetEntityCounts(string filePath)
    {
        using var model = IfcStore.Open(filePath);
        var instances = model.Instances;

        foreach (var instance in instances)
        {
           string name = instance.ExpressType.ExpressName;
           Console.WriteLine($"Processing entity: {name}");
        }

        var groups = instances
            .GroupBy(inst => inst.ExpressType.Name)
            .Select(g => new EntityCount
            {
                EntityType = g.Key,
                Count = g.Count()
            })
            .ToList();

        return groups;
    }
}