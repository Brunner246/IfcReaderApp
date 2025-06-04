namespace IfcReaderApp.Application.Interfaces;

public interface IIfcProcessor
{
    Task ProcessAsync(string filePath);
}