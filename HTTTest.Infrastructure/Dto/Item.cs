using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTTTest.Infrastructure.Dto;
/// <summary>
/// Сущность продукта Dto.
/// </summary>
public class Item
{
    //Айди продукта
    public int Id { get; set; }
    
    //Название продукта
    public string Name { get; set; } 
    
    //Стоимость
    public double Price { get; set; }
    
    //Список категорий
    public List<Category> Categories { get; set; } 
    
}