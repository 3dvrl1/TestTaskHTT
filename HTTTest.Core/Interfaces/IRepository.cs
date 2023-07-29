using Item = HTTTest.Core.Entities.Item;

namespace HTTTest.Core.Interfaces;

/// <summary>
/// Интерфейс для модели поведения репозитория
/// </summary>
public interface IRepository
{
    public Task<List<Item>> GetAllItems();
    
}