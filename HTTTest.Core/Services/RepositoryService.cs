using AutoMapper;
using HTTTest.Core.Entities;
using HTTTest.Core.Interfaces;
using HTTTest.Infrastructure.Context;
using HTTTest.Infrastructure.Dto;
using Microsoft.EntityFrameworkCore;
using Item = HTTTest.Infrastructure.Dto.Item;

namespace HTTTest.Core.Services;

/// <summary>
/// Репозиторий для работы с базой данных
/// </summary>
public class RepositoryService : IRepository
{
    private readonly Mapper _mapper;
    private readonly LocalDataBaseContext _localDataBaseContext;

    public RepositoryService(LocalDataBaseContext localDataBaseContext, Mapper mapper)
    {
        _localDataBaseContext = localDataBaseContext;
        _mapper = mapper;
    }

    public async Task<List<Entities.Item>> GetAllItems()
    {
        return await _localDataBaseContext
            .Items
            .Include(n=>n.Categories)
            .Select(n=> _mapper.Map<Item, Entities.Item>(n))
            .ToListAsync();
    }
    
}

