using IfcReaderApp.Application.Interfaces;
using IfcReaderApp.Domain.Models;

namespace IfcReaderApp.Application.Services;

public class IfcProcessor : IIfcProcessor
{
    private readonly IIfcFileReader _reader;

    public IfcProcessor(IIfcFileReader reader)
    {
        _reader = reader;
    }

    public Task ProcessAsync(string filePath)
    {
        var entityCounts = _reader.GetEntityCounts(filePath);

        Console.WriteLine("== IFC Entity Type Counts ==");
        foreach (var count in entityCounts.OrderByDescending(e => e.Count))
        {
            Console.WriteLine($"{count.EntityType}: {count.Count}");
        }

        return Task.CompletedTask;
    }
}