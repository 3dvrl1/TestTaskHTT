using HTTTest.Core.Interfaces;
using HTTTest.Infrastructure.Dto;
using Item = HTTTest.Core.Entities.Item;

namespace HTTTest.Core.Services;
/// <summary>
/// Сервис для работы с продуктом
/// </summary>
public class ItemService:IItemService
{
    private readonly IRepository _repository;

    public ItemService(IRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<Item>> GetAllItemsAsync()
    {
        return await _repository.GetAllItems();
    }
}