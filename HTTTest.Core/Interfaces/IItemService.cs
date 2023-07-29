using HTTTest.Core.Entities;

namespace HTTTest.Core.Interfaces;

/// <summary>
/// Интерфейс для определения модели поведения сервиса для работы с Продуктом
/// </summary>
public interface IItemService
{
    public Task<List<Item>> GetAllItemsAsync();
}