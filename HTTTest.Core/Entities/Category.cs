namespace HTTTest.Core.Entities;
/// <summary>
/// Сущность категории.
/// </summary>
public class Category
{
    //Id категории
    public int Id { get; set; }
    
    //Название продукта
    public string Name { get; set; } 
    
    //Список продуктов в категории
    public List<Item> Items { get; set; } 
}