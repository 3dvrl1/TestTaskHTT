using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HTTTest.Infrastructure.Dto;
/// <summary>
/// Сущность категории Dto
/// </summary>
public class Category
{
    //Айди категории
    public int Id { get; set; }
    
    //Имя категории
    public string Name { get; set; } 
    
    //Список товаров у категории
    public List<Item> Items { get; set; } 
    
}