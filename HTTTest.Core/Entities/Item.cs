namespace HTTTest.Core.Entities;
/// <summary>
/// Сущность продукта
/// </summary>
public class Item
{
    // Айди продукта
    public int Id { get; set; }
    
    //Название пробела
    public string Name { get; set; }
    
    //Стоимость продукта
    public double Price { get; set; }
    
    //Список категорий продукта
    public List<Category> Categories { get; set; }
}