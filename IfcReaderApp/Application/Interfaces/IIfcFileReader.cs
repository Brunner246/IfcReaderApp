﻿using IfcReaderApp.Domain.Models;

namespace IfcReaderApp.Application.Interfaces;

public interface IIfcFileReader
{
    List<EntityCount> GetEntityCounts(string filePath);
    Task<List<EntityCount>> GetEntityCountsAsync(string filePath);
}